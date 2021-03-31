USE [Tajemnik]
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spZamestnanec_Insert]
	-- Add the parameters for the stored procedure here
	@Jmeno nvarchar (100),
	@Prijmeni nvarchar(100),
	@ID int=0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

  insert into dbo.Zamestnanec (Jmeno, Prijmeni, ID)
  values (@Jmeno,@Prijmeni,@ID) 

  --La ultima identity insertada en la tabla
  select @id= SCOPE_IDENTITY(); 

END
