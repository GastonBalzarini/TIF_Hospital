CREATE PROCEDURE spActualizarMedicoYAdministrador
    @Usuario_AYM VARCHAR(50),
    @Contrase�a_AYM VARCHAR(50)
AS
BEGIN
    UPDATE Administradores_Y_Medicos
    SET Contrase�a_AYM = @Contrase�a_AYM
    WHERE Usuario_AYM = @Usuario_AYM;

    SELECT @@ROWCOUNT AS 'Filas actualizadas';
END

