BEGIN TRANSACTION Decrease_Quantites
 
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
	SELECT * from cr.Raw_Materials;