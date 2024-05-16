insert into CR.Items VALUES(N'Cold Drinks',N'Banana Juice',20,'ss', ( select BulkColumn
 FROM Openrowset( Bulk 'E:\Food_Dirnk _Template.jpg', Single_Blob) as Picture))
select * from CR.Items ;

