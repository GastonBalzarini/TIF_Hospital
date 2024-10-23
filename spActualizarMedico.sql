USE [TPINT_GRUPO_14_PR3]
GO
/****** Object:  StoredProcedure [dbo].[spAgregarPaciente]    Script Date: 24/6/2024 21:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[spActualizarMedico]
(
    @Legajo_MED VARCHAR(10),
    @Nombre_MED VARCHAR(20),
    @Apellido_MED VARCHAR(20),
    @Id_Sexo_MED CHAR(1),
    @Id_Nacionalidad_MED VARCHAR(4),
    @Direccion_MED VARCHAR(30),
    @Cod_Localidad_MED VARCHAR(4),
    @Cod_Provincia_MED VARCHAR(4),
    @Correo_Electronico_MED VARCHAR(50),
    @Telefono_MED VARCHAR(15),
    @Id_Especialidad_MED VARCHAR(4)
)
AS
UPDATE Medicos
SET
Nombre_MED = @Nombre_MED,
Apellido_MED = @Apellido_MED,
Id_Sexo_MED = @Id_Sexo_MED,
Id_Nacionalidad_MED = @Id_Nacionalidad_MED,
Direccion_MED = @Direccion_MED,
Cod_Localidad_MED = @Cod_Localidad_MED,
Cod_Provincia_MED = @Cod_Provincia_MED,
Correo_Electronico_MED = @Correo_Electronico_MED,
Telefono_MED = @Telefono_MED,
Id_Especialidad_MED = @Id_Especialidad_MED
WHERE Legajo_MED = @Legajo_MED
RETURN



EXEC spActualizarMedico
    @Legajo_MED = '00001',
    @Nombre_MED = 'Juan carlos',
    @Apellido_MED = 'Pérez',
    @Id_Sexo_MED = 'M',
    @Id_Nacionalidad_MED = '0001',
    @Direccion_MED = 'Calle Falsa 666',
    @Cod_Localidad_MED = '0028',
    @Cod_Provincia_MED = '001',
    @Correo_Electronico_MED = 'juan.perez@example.com',
    @Telefono_MED = '47153570',
    @Id_Especialidad_MED = '0002'
