-- Insertar registros en Especialidades
INSERT INTO Especialidades (Id_Especialidad_ES, Nombre_ES)
SELECT 'ES01', 'Cardiología' UNION
SELECT 'ES02', 'Pediatría' UNION
SELECT 'ES03', 'Dermatología' UNION
SELECT 'ES04', 'Neurología' UNION
SELECT 'ES05', 'Ginecología' UNION
SELECT 'ES06', 'Oncología' UNION
SELECT 'ES07', 'Oftalmología' UNION
SELECT 'ES08', 'Traumatología' UNION
SELECT 'ES09', 'Gastroenterología' UNION
SELECT 'ES10', 'Medicina Interna' UNION
SELECT 'ES11', 'Psiquiatría' UNION
SELECT 'ES12', 'Endocrinología' UNION
SELECT 'ES13', 'Nefrología' UNION
SELECT 'ES14', 'Reumatología' UNION
SELECT 'ES15', 'Infectología';
GO

-- Insertar registros en Nacionalidad
INSERT INTO Nacionalidad (Id_Nacionalidad_NAC, Nombre_NAC)
SELECT 'NAC1', 'Argentina' UNION
SELECT 'NAC2', 'Chile' UNION
SELECT 'NAC3', 'Uruguay' UNION
SELECT 'NAC4', 'Paraguay';
SELECT 'NAC5', 'Brasil' UNION
SELECT 'NAC6', 'Colombia' UNION
SELECT 'NAC7', 'Perú' UNION
SELECT 'NAC8', 'Venezuela' UNION
SELECT 'NAC9', 'Ecuador' UNION
SELECT 'NA10', 'Bolivia' UNION
SELECT 'NA11', 'España' UNION
SELECT 'NA12', 'Francia' UNION
SELECT 'NA13', 'China' UNION
SELECT 'NA14', 'México' UNION
SELECT 'NA15', 'Estados Unidos';
GO

GO

-- Insertar registros en Sexo
INSERT INTO Sexo (Id_Sexo_S, Nombre_S)
SELECT 'M', 'Masculino' UNION
SELECT 'F', 'Femenino' UNION
SELECT 'N', 'No binario';
GO

-- Insertar registros en Provincias
INSERT INTO Provincias (Id_Provincia_PROV, Nombre_PROV)
SELECT 'P1', 'Buenos Aires' UNION
SELECT 'P2', 'CABA' UNION
SELECT 'P3', 'Córdoba' UNION
SELECT 'P4', 'Santa Fe' UNION
SELECT 'P5', 'Mendoza' UNION
SELECT 'P6', 'Tucumán' UNION
SELECT 'P7', 'Salta' UNION
SELECT 'P8', 'Jujuy' UNION
SELECT 'P9', 'Catamarca' UNION
SELECT 'P10', 'La Rioja' UNION
SELECT 'P11', 'San Juan' UNION
SELECT 'P12', 'Neuquén' UNION
SELECT 'P13', 'Río Negro' UNION
SELECT 'P14', 'Chubut' UNION
SELECT 'P15', 'Santa Cruz';
GO

-- Insertar registros en Localidades
INSERT INTO Localidades (Id_Localidades_LO, Id_Provincia_LO, Nombre_LO)
SELECT 'LOC1', 'P1', 'La Plata' UNION
SELECT 'LOC2', 'P1', 'Mar del Plata' UNION
SELECT 'LOC3', 'P2', 'Buenos Aires' UNION
SELECT 'LOC4', 'P2', 'San Telmo' UNION
SELECT 'LOC5', 'P3', 'Córdoba Capital' UNION
SELECT 'LOC6', 'P3', 'Villa Carlos Paz' UNION
SELECT 'LOC7', 'P4', 'Rosario' UNION
SELECT 'LOC8', 'P4', 'Santa Fe' UNION
SELECT 'LOC9', 'P5', 'Mendoza Capital' UNION
SELECT 'LO10', 'P5', 'San Rafael' UNION
SELECT 'LO11', 'P6', 'San Miguel de Tuc' UNION
SELECT 'LO12', 'P6', 'Tafí Viejo' UNION
SELECT 'LO13', 'P7', 'Salta Capital' UNION
SELECT 'LO14', 'P7', 'Orán' UNION
SELECT 'LO15', 'P8', 'San Salvador de Juju' UNION
SELECT 'LO16', 'P8', 'Palpalá' UNION
SELECT 'LO17', 'P9', 'Catamarca Capital' UNION
SELECT 'LO18', 'P9', 'Santa María' UNION
SELECT 'LO19', 'P10', 'La Rioja Capital' UNION
SELECT 'LO20', 'P10', 'Chamical' UNION
SELECT 'LO21', 'P11', 'San Juan Capital' UNION
SELECT 'LO22', 'P11', 'Rawson' UNION
SELECT 'LO23', 'P12', 'Neuquén Capital' UNION
SELECT 'LO24', 'P12', 'Plottier' UNION
SELECT 'LO25', 'P13', 'Viedma' UNION
SELECT 'LO26', 'P13', 'Carmen de Patagones' UNION
SELECT 'LO27', 'P14', 'Trelew' UNION
SELECT 'LO28', 'P14', 'Rawson' UNION
SELECT 'LO29', 'P15', 'Río Gallegos' UNION
SELECT 'LO30', 'P15', 'El Calafate';
GO

-- Insertar registros en Administradores_y_Medicos
INSERT INTO Administradores_y_Medicos (Usuario_AYM, Contraseña_AYM, Tipo_Usuario_AYM)
SELECT 'admin1', 'pass1', 'Administrador' UNION
SELECT 'admin2', 'pass2', 'Administrador' UNION
SELECT 'medico1', 'medpass1', 'Medico' UNION
SELECT 'medico2', 'medpass2', 'Medico' UNION
SELECT 'medico3', 'medpass3', 'Medico' UNION
SELECT 'medico4', 'medpass4', 'Medico' UNION
SELECT 'medico5', 'medpass5', 'Medico' UNION
SELECT 'medico6', 'medpass6', 'Medico' UNION
SELECT 'medico7', 'medpass7', 'Medico' UNION
SELECT 'medico8', 'medpass8', 'Medico' UNION
SELECT 'medico9', 'medpass9', 'Medico' UNION
SELECT 'medico10', 'medpass10', 'Medico' UNION
SELECT 'medico11', 'medpass11', 'Medico' UNION
SELECT 'medico12', 'medpass12', 'Medico' UNION
SELECT 'medico13', 'medpass13', 'Medico' UNION
SELECT 'medico14', 'medpass14', 'Medico' UNION
SELECT 'medico15', 'medpass15', 'Medico';
GO

-- Insertar registros en Medicos
INSERT INTO Medicos (Legajo_MED, Dni_MED, Nombre_MED, Apellido_MED, Id_Sexo_MED, Id_Nacionalidad_MED, Fecha_Nacimiento_MED, Direccion_MED, Cod_Localidad_MED, Cod_Provincia_MED, Correo_Electronico_MED, Telefono_MED, Id_Especialidad_MED, Usuario_MED, Tipo_Usuario_MED, Estado_MED)
SELECT 'MED1', '12345678', 'Juan', 'Pérez', 'M', 'NAC1', '1980-01-01', 'Av. Libertador 1234', 'LOC1', 'P1', 'juan.perez@mail.com', '01123456789', 'ES01', 'medico1', 'Medico', 1 UNION
SELECT 'MED2', '87654321', 'Ana', 'Gómez', 'F', 'NAC2', '1990-02-02', 'Calle Falsa 123', 'LOC3', 'P2', 'ana.gomez@mail.com', '01198765432', 'ES02', 'medico2', 'Medico', 1 UNION
SELECT 'MED3', '11223344', 'Luis', 'Martínez', 'M', 'NAC3', '1985-03-03', 'Calle 10', 'LOC5', 'P3', 'luis.martinez@mail.com', '01122334455', 'ES03', 'medico3', 'Medico', 0 UNION
SELECT 'MED4', '55667788', 'Laura', 'Sánchez', 'F', 'NAC1', '1995-04-04', 'Av. Siempre Viva', 'LOC7', 'P4', 'laura.sanchez@mail.com', '01155667788', 'ES04', 'medico4', 'Medico', 1 UNION
SELECT 'MED5', '22334455', 'Carlos', 'Lopez', 'M', 'NAC2', '1988-05-05', 'Calle 5', 'LOC9', 'P5', 'carlos.lopez@mail.com', '01122334466', 'ES05', 'medico5', 'Medico', 1 UNION
SELECT 'MED6', '33445566', 'María', 'Rodríguez', 'F', 'NAC3', '1982-06-06', 'Calle 12', 'LO11', 'P6', 'maria.rodriguez@mail.com', '01133445577', 'ES06', 'medico6', 'Medico', 1 UNION
SELECT 'MED7', '44556677', 'Fernando', 'Hernández', 'M', 'NAC4', '1991-07-07', 'Calle 15', 'LO13', 'P7', 'fernando.hernandez@mail.com', '01144556688', 'ES07', 'medico7', 'Medico', 1 UNION
SELECT 'MED8', '55667799', 'Elena', 'Fernández', 'F', 'NAC1', '1984-08-08', 'Calle 18', 'LO15', 'P8', 'elena.fernandez@mail.com', '01155667799', 'ES08', 'medico8', 'Medico', 1 UNION
SELECT 'MED9', '66778800', 'David', 'Martínez', 'M', 'NAC2', '1993-09-09', 'Calle 21', 'LO17', 'P9', 'david.martinez@mail.com', '01166778800', 'ES09', 'medico9', 'Medico', 1 UNION
SELECT 'MED10', '77889911', 'Isabel', 'García', 'F', 'NAC3', '1989-10-10', 'Calle 24', 'LO19', 'P10', 'isabel.garcia@mail.com', '01177889911', 'ES10', 'medico10', 'Medico', 1 UNION
SELECT 'MED11', '88990022', 'Jorge', 'Cruz', 'M', 'NAC4', '1987-11-11', 'Calle 27', 'LO21', 'P11', 'jorge.cruz@mail.com', '01188990022', 'ES11', 'medico11', 'Medico', 1 UNION
SELECT 'MED12', '99001133', 'Lucía', 'Morales', 'F', 'NAC1', '1983-12-12', 'Calle 30', 'LO23', 'P12', 'lucia.morales@mail.com', '01199001133', 'ES12', 'medico12', 'Medico', 1 UNION
SELECT 'MED13', '10020030', 'José', 'Reyes', 'M', 'NAC2', '1990-01-13', 'Calle 33', 'LO25', 'P13', 'jose.reyes@mail.com', '01110020030', 'ES13', 'medico13', 'Medico', 1 UNION
SELECT 'MED14', '11022044', 'Patricia', 'Vázquez', 'F', 'NAC3', '1985-02-14', 'Calle 36', 'LO27', 'P14', 'patricia.vazquez@mail.com', '01111022044', 'ES14', 'medico14', 'Medico', 1 UNION
SELECT 'MED15', '12034056', 'Raúl', 'Córdoba', 'M', 'NAC4', '1988-03-15', 'Calle 39', 'LO29', 'P15', 'raul.cordoba@mail.com', '01112034056', 'ES15', 'medico15', 'Medico', 1;
GO

INSERT INTO Pacientes (Dni_PAC, Nombre_PAC, Apellido_PAC, Id_Sexo_PAC, Id_Nacionalidad_PAC, Fecha_Nacimiento_PAC, Direccion_PAC, Cod_Localidad_PAC, Cod_Provincia_PAC, Correo_Electronico_PAC, Telefono_PAC, Estado_PAC) VALUES
('22222222', 'Carlos', 'Lopez', 'M', 'NAC1', '1985-03-03', 'Av. Corrientes 456', 'LOC1', 'P1', 'carlos.lopez@mail.com', '01122223344', 1),
('33333333', 'María', 'Rodríguez', 'F', 'NAC2', '1995-04-04', 'Calle Sucre 789', 'LOC2', 'P1', 'maria.rodriguez@mail.com', '01133334455', 1),
('44444444', 'Ana', 'Martinez', 'F', 'NAC3', '1990-05-05', 'Calle 10', 'LOC3', 'P2', 'ana.martinez@mail.com', '01144445566', 1),
('55555555', 'José', 'González', 'M', 'NAC4', '1988-06-06', 'Calle 20', 'LOC4', 'P2', 'jose.gonzalez@mail.com', '01155556677', 0),
('66666666', 'Patricia', 'Cruz', 'F', 'NAC1', '1983-07-07', 'Calle 30', 'LOC5', 'P3', 'patricia.cruz@mail.com', '01166667788', 1),
('77777777', 'Luis', 'Ramírez', 'M', 'NAC2', '1981-08-08', 'Calle 40', 'LOC6', 'P3', 'luis.ramirez@mail.com', '01177778899', 1),
('88888888', 'Lucía', 'Salinas', 'F', 'NAC3', '1992-09-09', 'Calle 50', 'LOC7', 'P4', 'lucia.salinas@mail.com', '01188889900', 1),
('99999999', 'Fernando', 'Alvarez', 'M', 'NAC4', '1980-10-10', 'Calle 60', 'LOC8', 'P4', 'fernando.alvarez@mail.com', '01199990011', 1),
('10101010', 'Sofía', 'Moreno', 'F', 'NAC1', '1995-11-11', 'Calle 70', 'LOC9', 'P5', 'sofia.moreno@mail.com', '01110101022', 1),
('11111111', 'Javier', 'Vásquez', 'M', 'NAC2', '1984-12-12', 'Calle 80', 'LO10', 'P5', 'javier.vasquez@mail.com', '01111111233', 0),
('12121212', 'Raquel', 'Torres', 'F', 'NAC3', '1993-01-01', 'Calle 90', 'LO11', 'P6', 'raquel.torres@mail.com', '01112121344', 1),
('13131313', 'Carlos', 'Rojas', 'M', 'NAC4', '1986-02-02', 'Calle 100', 'LO12', 'P6', 'carlos.rojas@mail.com', '01113131455', 1),
('14141414', 'Patricio', 'Maldonado', 'M', 'NAC1', '1989-03-03', 'Calle 110', 'LO13', 'P7', 'patricio.maldonado@mail.com', '01114141566', 1),
('15151515', 'Belén', 'Salcedo', 'F', 'NAC2', '1991-04-04', 'Calle 120', 'LO14', 'P7', 'belen.salcedo@mail.com', '01115151677', 1);

-- Insertar registros en Medicos_X_Dias
INSERT INTO Medicos_X_Dias (Legajo_MXD, Dia_MXD, Hora_Atencion_MXD) VALUES
('MED1', 'Lunes', '08:00'),
('MED1', 'Martes', '09:00'),
('MED1', 'Miercoles', '10:00'),
('MED1', 'Jueves', '11:00'),
('MED1', 'Viernes', '12:00'),

('MED2', 'Lunes', '09:00'),
('MED2', 'Martes', '10:00'),
('MED2', 'Miercoles', '11:00'),
('MED2', 'Jueves', '12:00'),
('MED2', 'Viernes', '13:00'),



('MED4', 'Lunes', '09:00'),
('MED4', 'Martes', '10:00'),
('MED4', 'Miercoles', '11:00'),
('MED4', 'Jueves', '12:00'),
('MED4', 'Viernes', '13:00'),

('MED5', 'Lunes', '08:00'),
('MED5', 'Martes', '09:00'),
('MED5', 'Miercoles', '10:00'),
('MED5', 'Jueves', '11:00'),
('MED5', 'Viernes', '12:00'),

('MED6', 'Lunes', '09:00'),
('MED6', 'Martes', '10:00'),
('MED6', 'Miercoles', '11:00'),
('MED6', 'Jueves', '12:00'),
('MED6', 'Viernes', '13:00'),

('MED7', 'Lunes', '08:00'),
('MED7', 'Martes', '09:00'),
('MED7', 'Miercoles', '10:00'),
('MED7', 'Jueves', '11:00'),
('MED7', 'Viernes', '12:00'),

('MED8', 'Lunes', '09:00'),
('MED8', 'Martes', '10:00'),
('MED8', 'Miercoles', '11:00'),
('MED8', 'Jueves', '12:00'),
('MED8', 'Viernes', '13:00'),



('MED10', 'Lunes', '09:00'),
('MED10', 'Martes', '10:00'),
('MED10', 'Miercoles', '11:00'),
('MED10', 'Jueves', '12:00'),
('MED10', 'Viernes', '13:00');

-- Insertar registros en Turnos
INSERT INTO Turnos (Legajo_TUR, Dia_TUR, Hora_TUR, Dni_Paciente_TUR, Observacion_TUR, Asistencia_TUR) VALUES
('MED1', 'Lunes', '08:00', '22222222', 'Consulta general', 1),
('MED1', 'Martes', '09:00', '33333333', 'Chequeo general', 1),
('MED2', 'Lunes', '09:00', '44444444', 'Consulta médica', 0),
('MED2', 'Martes', '10:00', '55555555', 'Chequeo anual', 1),
('MED3', 'Miércoles', '09:00', '66666666', 'Control', 1),
('MED3', 'Jueves', '10:00', '77777777', 'Consulta', 0),
('MED4', 'Jueves', '12:00', '88888888', 'Consulta médica', 0),
('MED4', 'Viernes', '13:00', '99999999', 'Chequeo anual', 1),
('MED5', 'Lunes', '08:00', '10101010', 'Consulta general', 1),
('MED5', 'Martes', '09:00', '11111111', 'Chequeo', 1),
('MED6', 'Lunes', '09:00', '12121212', 'Consulta',0),
('MED6', 'Martes', '10:00', '13131313', 'Control', 1),
('MED7', 'Lunes', '08:00', '14141414', 'Consulta general', 1),
('MED7', 'Martes', '09:00', '15151515', 'Chequeo anual', 1),
('MED8', 'Jueves', '12:00', '22222222', 'Consulta médica', 1),
('MED8', 'Viernes', '13:00', '33333333', 'Chequeo', 0),
('MED10', 'Martes', '10:00', '44444444', 'Control', 1),
('MED10', 'Miércoles', '11:00', '55555555', 'Consulta general', 0);
