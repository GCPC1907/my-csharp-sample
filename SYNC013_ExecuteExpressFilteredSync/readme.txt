���Բ���:

1. ������  ProvisionServerWithFilteredScope.exe  �����˻���


2. ������  ProvisionFilteredScopeClient.exe  ��ͻ��˻���


3. ���� ExecuteExpressFilteredSync.exe �״�ͬ��


��������
Start Time: 2014/12/19 15:26:18
Total Changes Uploaded: 0
Total Changes Downloaded: 2
Complete Time: 2014/12/19 15:26:19



�ͻ������ݲ�ѯ.

SELECT TOP 1000 [OrderID]
      ,[ProductID]
      ,[Quantity]
      ,[OriginState]
  FROM [SyncExpressDB].[dbo].[Orders]
GO

OrderID     ProductID   Quantity    OriginState
----------- ----------- ----------- -----------
1           1           2           NC
2           2           1           NC

(2 ����Ӱ��)




4. ���Է�������ݸ��£� Ȼ����ͬ�����ͻ���.

INSERT INTO [SyncDB].[dbo].[Orders] VALUES (5, 1, 1, 'NC')
INSERT INTO [SyncDB].[dbo].[Orders] VALUES (6, 1, 1, 'WA')
INSERT INTO [SyncDB].[dbo].[Orders] VALUES (7, 1, 1, 'NC')
GO

(0 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)

(0 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)

(0 ����Ӱ��)

(1 ����Ӱ��)

(1 ����Ӱ��)



5. �ٴ����� ExecuteExpressSync.exe ���еڶ���ͬ��

Start Time: 2014/12/19 15:31:57
Total Changes Uploaded: 0
Total Changes Downloaded: 2
Complete Time: 2014/12/19 15:31:57




�ͻ������ݲ�ѯ.

SELECT TOP 1000 [OrderID]
      ,[ProductID]
      ,[Quantity]
      ,[OriginState]
  FROM [SyncExpressDB].[dbo].[Orders]
GO

OrderID     ProductID   Quantity    OriginState
----------- ----------- ----------- -----------
1           1           2           NC
2           2           1           NC
5           1           1           NC
7           1           1           NC

(4 ����Ӱ��)








