
-- ����ͬ�������У��ͻ��ˣ������������ݵĽű�.

USE [master]
GO

IF EXISTS(SELECT name FROM sys.databases WHERE name = 'SyncExpressDB')
DROP DATABASE SyncExpressDB

CREATE DATABASE [SyncExpressDB] 
GO

