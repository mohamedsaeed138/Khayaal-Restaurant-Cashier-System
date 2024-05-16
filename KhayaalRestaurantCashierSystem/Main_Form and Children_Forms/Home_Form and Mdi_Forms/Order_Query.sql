/*BEGIN TRANSACTION Decrease_Quantites
 
  EXEC CR.Decrease_Raw_Materials_Qty	
	@Item_Id=1,@Qty=5;
 
 IF (Select COUNT(CR.Raw_Materials.Id) FROM CR.Raw_Materials WHERE Qty<0)>0
    BEGIN 
      ROLLBACK TRANSACTION Decrease_Quantites
      
    END
  ELSE
    BEGIN
      COMMIT TRANSACTION Decrease_Quantites
	  
    END
	SELECT * from cr.Raw_Materials;*/-- there is a way better

    /*TRUNCATE TABLE CR.Raw_Materials_Test;

INSERT INTO CR.Raw_Materials_Test (Id,Category,Name,Qty)
SELECT Id,Category,Name,Qty FROM CR.Raw_Materials

EXEC CR.Decrease_Raw_Materials_Qty_Test @Item_Id=1,@Qty=1;
SELECT [Name],Qty FROM CR.Raw_Materials_Test Where Qty<0;
*/--The good way


/*IMAGE QUERY 
UPDATE CR.Items SET Image=BulkColumn from Openrowset( Bulk 'E:\Food_Dirnk _Template.jpg', Single_Blob) as Item_Image  WHERE Id !=  1;
SELECT * FROM CR.Items;
SELECT Image from CR.Items */