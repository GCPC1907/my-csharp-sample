����һ. 
	����һ����Ŀ�� ����Ϊ Windows����


�����.
	Service1.cs �ļ�������Ϊһ����������ļ��� ���籾��Ŀ�� HelloWorldService.cs
	Ȼ���д�������ش���.

������.
	�Ҽ� HelloWorldService.cs  (Ҳ���Ǳ��ļ�) ѡ�� [��ͼ�����]
    �ٵ�View Desiger [��ͼ�����] ��ͼ���Ҽ�, ѡ�� [��Ӱ�װ����]
    Installer ����Ӻ��ˡ�
    �˲�����ɺ� ��Ŀ�л����һ�� ProjectInstaller.cs ���ļ���


������.
	˫����һ���������ɵ� ProjectInstaller.cs�� ����ʾ��ƻ��档
	ѡ�� serviceProcessInstaller1
	�����Դ����У� �޸� Account ����Ϊ  LocalSystem

ע��Account ���ԵĿ�������ֵ����
LocalService �䵱���ؼ�����Ϸ���Ȩ�û����ʻ������ʻ�������ƾ���ṩ������Զ�̷������� 
NetworkService �ṩ�㷺�ı�����Ȩ���ʻ������ʻ����������ƾ���ṩ������Զ�̷������� 
LocalSystem ������ƹ���Աʹ�õ��ʻ��������б��ؼ�����ϵ����Ȩ�޲���Ϊ�����ϵļ������ 
User ���������ض����û�������ʻ��� ���Ϊ ServiceProcessInstaller.Account ��Աָ�� User�����ʹϵͳ�ڰ�װ����ʱ��ʾ������Ч���û��������룬������Ϊ ServiceProcessInstaller ʵ���� Username �� Password ��������������ֵ��  

	


������.
	ѡ�� serviceInstaller1
	�����Դ����У� �޸� ServiceName Ϊ������ķ������� ���籾��Ŀ��  HelloWorldService
	

������.
	���롢��װ���������С�ж�ط���