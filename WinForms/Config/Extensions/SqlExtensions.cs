using Microsoft.EntityFrameworkCore;

namespace WinForms.Config.Extensions;

public static class SqlExtensions
{
    public static void ExecuteSqlScriptAsync(this DbContext context, string path)
    {
        var basePath = AppContext.BaseDirectory;
        var fullPath = Path.Combine(basePath, path);
        if (!File.Exists(fullPath))
            throw new FileNotFoundException($"File {fullPath} not found");

        var config = context.Set<Modelo.Config>().FirstOrDefault();
        var execute = config?.ExecuteInit ?? true;
        if(!execute) 
            return;
        var script = File.ReadAllText(fullPath);
        context.Database.ExecuteSqlRaw(script);
    } 
}