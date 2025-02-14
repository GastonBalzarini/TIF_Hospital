CREATE PROCEDURE spActualizarMedicoYAdministrador
    @Usuario_AYM VARCHAR(50),
    @Contraseņa_AYM VARCHAR(50)
AS
BEGIN
    UPDATE Administradores_Y_Medicos
    SET Contraseņa_AYM = @Contraseņa_AYM
    WHERE Usuario_AYM = @Usuario_AYM;

    SELECT @@ROWCOUNT AS 'Filas actualizadas';
END

