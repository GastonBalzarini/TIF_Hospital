USE [TPINT_GRUPO_14_PR3]
GO
CREATE PROCEDURE spAgregarUsuario
    @Usuario VARCHAR(10),
    @Contrasenia VARCHAR(10),
    @Tipo_Usuario VARCHAR(15)
AS
BEGIN
    SET NOCOUNT ON;

    -- Insertar el nuevo usuario en la tabla
    INSERT INTO Administradores_y_Medicos (Usuario_AYM, Contraseña_AYM, Tipo_Usuario_AYM)
    VALUES (@Usuario, @Contrasenia, @Tipo_Usuario);

    -- Confirmar éxito
    SELECT @@ROWCOUNT AS FilasInsertadas;
END
