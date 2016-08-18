ʹ�� Fleck ������ WebSocket 



����1. ��Ŀ�����ã���� NuGet ����� Fleck.



����2. ������Ҫ�� �Լ���д�¼��������.


// ����һ�� WebSocket ���� ��������.
var echoServer = new WebSocketServer("ws://127.0.0.1:8181/Echo");
echoServer.Start(socket =>
{
	socket.OnOpen = () => 
	{
		Console.WriteLine("echoServer ���Ӵ�.");
	};

	socket.OnClose = () =>
	{
		Console.WriteLine("echoServer ���ӹر�.");
	};

	socket.OnMessage = message =>
	{
		Console.WriteLine("echoServer���յ��ͻ��˵�����{0}, ��ԭ������.", message);
		socket.Send(message);
	};

	socket.OnError = (error) =>
	{
		Console.WriteLine("��ѽ��echoServer ����������......" + error.ToString());
	};

	socket.OnPing = (buff) =>
	{
		Console.WriteLine("echoServer���յ� Ping ��");
	};

	socket.OnPong = (buff) =>
	{
		Console.WriteLine("echoServer���յ� Pong ��");
	};

});