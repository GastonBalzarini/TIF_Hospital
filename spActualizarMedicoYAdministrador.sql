CREATE PROCEDURE spActualizarMedicoYAdministrador
    @Usuario_AYM VARCHAR(50),
    @Contraseña_AYM VARCHAR(50)
AS
BEGIN
    UPDATE Administradores_Y_Medicos
    SET Contraseña_AYM = @Contraseña_AYM
    WHERE Usuario_AYM = @Usuario_AYM;

    SELECT @@ROWCOUNT AS 'Filas actualizadas';
END

