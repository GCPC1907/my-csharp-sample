���Բ���:

1. ������  ProvisionServer.exe  �����˻���


2. ������  ProvisionClient.exe  ��ͻ��˻���


3. ���� ExecuteExpressSync.exe �״�ͬ��


��������
Start Time: 2014/12/19 14:29:40
Total Changes Uploaded: 0
Total Changes Downloaded: 3
Complete Time: 2014/12/19 14:29:42

�ͻ������ݲ�ѯ.

SELECT 
	[ID],[Name],[ListPrice]
FROM 
	[SyncExpressDB].[dbo].[Products]
GO

ID          Name                                               ListPrice
----------- -------------------------------------------------- ---------------------
1           PC                                                 400.00
2           Laptop                                             600.00
3           NetBook                                            300.00

(3 ����Ӱ��)



4. ���Է�������ݸ��£� Ȼ����ͬ�����ͻ���.

INSERT INTO Products VALUES (4, 'iPad', 500);

(0 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)



5. �ٴ����� ExecuteExpressSync.exe ���еڶ���ͬ��

Start Time: 2014/12/19 14:34:54
Total Changes Uploaded: 0
Total Changes Downloaded: 1
Complete Time: 2014/12/19 14:34:55

�ͻ������ݲ�ѯ.

SELECT 
	[ID],[Name],[ListPrice]
FROM 
	[SyncExpressDB].[dbo].[Products]
GO

ID          Name                                               ListPrice
----------- -------------------------------------------------- ---------------------
1           PC                                                 400.00
2           Laptop                                             600.00
3           NetBook                                            300.00
4           iPad                                               500.00

(4 ����Ӱ��)



6. ���� �ͻ��� ���� / �������ݣ� �� ͬ���� �����.

INSERT INTO [SyncExpressDB].[dbo].[Products] VALUES (5, 'iPhone', 600);

UPDATE [SyncExpressDB].[dbo].[Products] SET Name = 'iPad Air' WHERE id = 4;
GO

(0 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)




7. �ٴ����� ExecuteExpressSync.exe ���е�����ͬ��.

Start Time: 2014/12/19 14:38:26
Total Changes Uploaded: 2
Total Changes Downloaded: 0
Complete Time: 2014/12/19 14:38:27


����˺˶�����.

SELECT TOP 1000 [ID]
      ,[Name]
      ,[ListPrice]
  FROM [SyncDB].[dbo].[Products]
GO

ID          Name                                               ListPrice
----------- -------------------------------------------------- ---------------------
1           PC                                                 400.00
2           Laptop                                             600.00
3           NetBook                                            300.00
4           iPad Air                                           500.00
5           iPhone                                             600.00

(5 ����Ӱ��)






