using Microsoft.Win32;
RegistryView registryViewArchitecture = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
List<string> servers = new List<string>();

// Verificando as versões do SQL Server Local DB instaladas
using (var registryKeyLocalMachine = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryViewArchitecture))
{
    var localDbKey = registryKeyLocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions", false);

    if (localDbKey != null)
    {
        Console.WriteLine("Versões do SQL Server Local DB instaladas:");

        foreach (var versionKeyName in localDbKey.GetSubKeyNames())
        {
            servers.Add($"(localdb)\\{versionKeyName}");
            Console.WriteLine($"- (localdb)\\{versionKeyName}");
        }
    }
    else
    {
        Console.WriteLine("SQL Server Local DB não está instalado.");
    }
}

// Exibindo as informações para conexão e a string de conexão
Console.WriteLine("\nInformações para conexão:");
foreach (var server in servers)
{
    string connectionString = GetConnectionString(server);
    Console.WriteLine($"Tipo de Servidor: SQL Server");
    Console.WriteLine($"Nome do Servidor: {server}");
    Console.WriteLine($"Autenticação: Autenticação Integrada (Windows)");
    Console.WriteLine($"String de Conexão: {connectionString}");
    Console.WriteLine();
}

Console.ReadKey();


static string GetConnectionString(string server)
{
    return $"Server={server};Integrated Security=true;";
}
