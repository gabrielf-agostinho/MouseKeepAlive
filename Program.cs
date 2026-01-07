Console.Title = "Mouse Keep Alive";
Console.WriteLine("Mouse Keep Alive iniciado...");
Console.WriteLine("Moverá o mouse após 2 minutos de inatividade.");
Console.WriteLine("Pressione CTRL+C para encerrar.\n");

var maxIdleTime = TimeSpan.FromMinutes(2);

while (true)
{
    PowerHelper.KeepAwake();
    var idleTime = IdleTimeHelper.GetIdleTime();

    if (idleTime >= maxIdleTime)
    {
        Console.WriteLine($"[{DateTime.Now:HH:mm:ss}] Mouse parado por {idleTime:hh\\:mm\\:ss}. Movendo...");
        MouseHelper.MoveNaturally();
    }

    Thread.Sleep(TimeSpan.FromSeconds(10));
}