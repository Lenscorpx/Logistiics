USE [db_logistik]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[charger_matricule]

SELECT	@return_value as 'Return Value'

GO
create procedure recuperer_nom_equipement
@code_approvisionnement nvarchar(50)
as
	select code_equipement from t_approvisionnement
	where code_approvisionnement=@code_approvisionnement
	go