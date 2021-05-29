# EasyBilling
Simple billing application using C#

How to setup project:
1.Project is created on visual studio 2019.
2.Install microsoft SQL 2005 and above.
3.Open sql management studio or query express and execute this script "EasyBillingSQLScripts.sql"[File is in project path].
and select EasyBilling database and execute this query
INSERT [dbo].[tbl_users] ([id], [first_name], [last_name], [email], [username], [password], [contact], [address], [gender], [user_type], [added_date], [added_by]) VALUES (5, N'admin', N'admin', N'admin@relyon.com', N'admin', N'admin@123', N'9999999999', N'WC road,rajajinagar,bengaluru', N'Not Specif', N'Admin', CAST(0x0000AD33016C9F2E AS DateTime), 1)
4.Open AppManager.cs file[ file path is "EasyBilling\BLL\Application\AppManager.cs"] and change connection string[search google to setup correct connection string for your SQL Server].
5.Open project and run and in login page enter user name as "admin" and user password as "admin@123" and select user type as "Admin" and continue.

youtube video reference for creating project is:
https://www.youtube.com/watch?v=Lttd3ohTarE&list=PLBLPjjQlnVXVnz3Hksi1th0uHXxh6Dm3h

Thanks & regards
Rajesh Narayan
Relyonsoftech ltd
