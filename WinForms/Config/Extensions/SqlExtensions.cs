using Microsoft.EntityFrameworkCore;

namespace WinForms.Config.Extensions;

public static class SqlExtensions
{
    public static async Task ExecuteSqlScriptAsync(this DbContext context, string path)
    {
        var basePath = AppContext.BaseDirectory;
        var fullPath = Path.Combine(basePath, path);
        if (!File.Exists(fullPath))
            throw new FileNotFoundException($"File {fullPath} not found");

        var config = await context.Set<Modelo.Config>().FirstOrDefaultAsync();
        var execute = config?.ExecuteInit ?? true;
        if(!execute) 
            return;
        var script = await File.ReadAllTextAsync(fullPath);
        await context.Database.ExecuteSqlRawAsync(script);
    } 
}