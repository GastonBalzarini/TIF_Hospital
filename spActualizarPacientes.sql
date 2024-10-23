use TPINT_GRUPO_14_PR3

CREATE PROCEDURE  [dbo].[spActualizarPaciente]
(
	@Dni VARCHAR(10),
    @Nombre VARCHAR(20),
    @Apellido VARCHAR(20),
    @Id_Sexo CHAR(1),
    @Id_Nacionalidad VARCHAR(4),
    @Direccion VARCHAR(30),
    @Cod_Localidad VARCHAR(4),
    @Cod_Provincia VARCHAR(4),
    @Correo_Electronico VARCHAR(50),
    @Telefono VARCHAR(15)
)
AS
UPDATE Pacientes
SET
Nombre_PAC = @Nombre,
Apellido_PAC = @Apellido,
Id_Sexo_PAC = @Id_Sexo,
Id_Nacionalidad_PAC = @Id_Nacionalidad,
Direccion_PAC = @Direccion,
Cod_Localidad_PAC = @Cod_Localidad,
Cod_Provincia_PAC = @Cod_Provincia,
Correo_Electronico_PAC = @Correo_Electronico,
Telefono_PAC = @Telefono
WHERE Dni_PAC = @Dni
RETURN