USE [TPINT_GRUPO_14_PR3]
GO

create PROCEDURE [dbo].[spInsertarMedicoDia]
    @Legajo_MXD VARCHAR(10),
    @Dia_MXD VARCHAR(10),
    @Hora_Atencion_MXD TIME 
AS
BEGIN
    INSERT INTO Medicos_X_Dias (Legajo_MXD, Dia_MXD, Hora_Atencion_MXD)
    VALUES (@Legajo_MXD, @Dia_MXD, @Hora_Atencion_MXD); 
END;