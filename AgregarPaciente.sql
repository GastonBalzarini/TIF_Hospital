USE [TPINT_GRUPO_14_PR3]
GO
/****** Object:  StoredProcedure [dbo].[spAgregarPaciente]    Script Date: 24/6/2024 21:20:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[spAgregarPaciente]
    @Dni_PAC VARCHAR(10),
    @Nombre_PAC VARCHAR(20),
    @Apellido_PAC VARCHAR(20),
    @Id_Sexo_PAC CHAR(1),
    @Id_Nacionalidad_PAC VARCHAR(4),
    @Fecha_Nacimiento_PAC DATE,
    @Direccion_PAC VARCHAR(30),
    @Cod_Localidad_PAC VARCHAR(4),
    @Cod_Provincia_PAC VARCHAR(4),
    @Correo_Electronico_PAC VARCHAR(50),
    @Telefono_PAC VARCHAR(15),
    @Estado_PAC BIT
AS
BEGIN
    INSERT INTO Pacientes (
        Dni_PAC,
        Nombre_PAC,
        Apellido_PAC,
        Id_Sexo_PAC,
        Id_Nacionalidad_PAC,
        Fecha_Nacimiento_PAC,
        Direccion_PAC,
        Cod_Localidad_PAC,
        Cod_Provincia_PAC,
        Correo_Electronico_PAC,
        Telefono_PAC,
        Estado_PAC
    )
    VALUES (
        @Dni_PAC,
        @Nombre_PAC,
        @Apellido_PAC,
        @Id_Sexo_PAC,
        @Id_Nacionalidad_PAC,
        @Fecha_Nacimiento_PAC,
        @Direccion_PAC,
        @Cod_Localidad_PAC,
        @Cod_Provincia_PAC,
        @Correo_Electronico_PAC,
        @Telefono_PAC,
        @Estado_PAC
    );
END;