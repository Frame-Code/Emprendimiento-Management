using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using Servicios.Interfaces;
using Shared;

namespace Servicios.Reports;

public class PremiacionReportPdf : IDocument, IReport
{
    private PremiacionDto? Data { get; set; }

    public DocumentMetadata GetMetadata() => DocumentMetadata.Default;

    public void Compose(IDocumentContainer container)
    {
        container.Page(page =>
        {
            page.Size(PageSizes.A4);
            page.Margin(25);
            page.DefaultTextStyle(x => x.FontSize(10));

            page.Header().Element(ComposeHeader);
            page.Content().Element(ComposeContent);
        });
    }

    private void ComposeHeader(IContainer container)
    {
        if(Data == null)
            return;
        
        container.Row(row =>
        {
            row.RelativeItem().Column(col =>
            {
                col.Item().Text($"Reporte de premiacion: {Data.Nombre}")
                    .FontSize(16)
                    .Bold()
                    .AlignCenter();
                
                col.Item().Text("");
                col.Item().Text("");

                col.Item().Text($"Fecha emisión: {DateTime.Now}")
                    .AlignLeft();
                
                col.Item().Text("");
                col.Item().Text($"Fecha registro: {Data.FechaCreacion}")
                    .AlignLeft();
                
                col.Item().Text("");
                col.Item().Text($"Fecha inicio premiación: {Data.FechaInicioPremiacion}")
                    .AlignLeft();
                
                col.Item().Text("");
                col.Item().Text($"Fecha fin premiación: {Data.FechaFinPremiacion}")
                    .AlignLeft();
                
                col.Item().Text("");
                col.Item().Text($"Observaciones: {Data.Observaciones}")
                    .AlignLeft();
                
                col.Item().Text("");
                col.Item().Text("");
            });
        });
    }

    private void ComposeContent(IContainer container)
    {
        container.Table(table =>
        {
            table.ColumnsDefinition(columns =>
            {
                columns.RelativeColumn(2);
                columns.RelativeColumn(4);
                columns.RelativeColumn(3);
                columns.RelativeColumn(2);
            });

            table.Header(header =>
            {
                header.Cell().Element(HeaderStyle).Text("Nombre emprendimiento");
                header.Cell().Element(HeaderStyle).Text("Facultad");
                header.Cell().Element(HeaderStyle).Text("Rubro emprendimiento");
                header.Cell().Element(HeaderStyle).Text("No. votos");
            });

            if (Data == null)
                return;
            
            foreach (var item in Data.EmprendimientoVoto)
            {
                table.Cell().Element(CellStyle).Text(item.Nombre);
                table.Cell().Element(CellStyle).Text(item.Facultad);
                table.Cell().Element(CellStyle).Text(item.Rubro);
                table.Cell().Element(CellStyle).Text(item.CantidadVotos.ToString());
            }
        });
    }

    private static IContainer HeaderStyle(IContainer container)
    {
        return container
            .Padding(5)
            .Background(Colors.Grey.Lighten2)
            .Border(1)
            .BorderColor(Colors.Grey.Darken1)
            .AlignCenter();
    }

    private static IContainer CellStyle(IContainer container)
    {
        return container
            .Padding(5)
            .BorderBottom(1)
            .BorderColor(Colors.Grey.Lighten1);
    }

    public TypeReport Report => TypeReport.PremiacionReporte;
    public async Task Export(string reportName, object data)
    {
        await Task.Run(() =>
        {
            Data = (PremiacionDto)data;
            this.GeneratePdf(reportName);
        });
    }
    
}