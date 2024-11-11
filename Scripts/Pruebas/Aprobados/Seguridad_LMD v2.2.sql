INSERT INTO `Tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'LOGISTICA', 'Logistica', 1),
('3000', 'COMPRAS Y VENTAS', 'Compras y Ventas', 1),
('5000', 'PRODUCCIÓN', 'Produccion', 1),
('6000', 'NOMINAS', 'Nominas', 1),
('7000', 'BANCOS', 'Bancos', 1),
('8000', 'CONTABILIDAD', 'Contabilidad', 1);

-- -----APLICACIONES
INSERT INTO `Tbl_aplicaciones` VALUES
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI LOGISTICA', 'PARA LOGISTICA', '1'),
('3000', 'MDI COMPRAS Y VENTAS', 'PARA COMPRAS Y VENTAS', '1'),
('5000', 'MDI PRODUCCIÓN', 'PARA PRODUCCIÓN', '1'),
('6000', 'MDI NOMINAS', 'PARA NOMINAS', '1'),
('6001', 'Mant. Trabajadores', 'PARA NOMINAS', '1'),
('6002', 'Mant. Puestos de Trabajo', 'PARA NOMINAS', '1'),
('6003', 'Mant. Departamentos', 'PARA NOMINAS', '1'),
('6004', 'Mant. Contratos', 'PARA NOMINAS', '1'),
('6005', 'Mant. Percepciones', 'PARA NOMINAS', '1'),
('6006', 'Mant. Horas Extras', 'PARA NOMINAS', '1'),
('6007', 'Mant. Faltas', 'PARA NOMINAS', '1'),
('6101', 'Asgn. Puesto - Depto.', 'PARA NOMINAS', '1'),
('6102', 'Asgn. Puesto - Trabajador', 'PARA NOMINAS', '1'),
('6103', 'Asgn. Contrato Trabajador', 'PARA NOMINAS', '1'),
('6104', 'Asgn. Prestaciones Contrato', 'PARA NOMINAS', '1'),
('6105', 'Asgn. Prestaciones Individual', 'PARA NOMINAS', '1'),
('6106', 'Prcs. Nomina', 'PARA NOMINAS', '1'),
('6201', 'Rpt. Planillas', 'PARA NOMINAS', '1'),
('6202', 'Rpt. Contratos', 'PARA NOMINAS', '1'),
('6203', 'Rpt. Trabajadores', 'PARA NOMINAS', '1'),
('6301', 'ACCESO SEGURIDAD', 'PARA NOMINAS', '1'),
('7000', 'MDI BANCOS', 'PARA BANCOS', '1'),
('8000', 'MDI CONTRABILIDAD', 'PARA CONTRABILIDAD', '1');



-- -----PERFILES
INSERT INTO `Tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'LOGISTICA', 'contiene todos los permisos de logistica', 1),
('4', 'COMPRAS Y VENTAS', 'contiene todos los permisos de compras y ventas', 1),
('5', 'PRODUCCIÓN', 'contiene todos los permisos de producción', 1),
('6', 'NOMINAS', 'contiene todos los permisos de nominas', 1),
('7', 'BANCOS', 'contiene todos los permisos de bancos', 1),
('8', 'CONTABILIDAD', 'contiene todos los permisos de contabilidad', 1);

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `Tbl_asignacion_modulo_aplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('3000', '3000'),
('5000', '5000'),
('6000', '6000'),
('6000', '6001'),
('6000', '6002'),
('6000', '6003'),
('6000', '6004'),
('6000', '6005'),
('6000', '6006'),
('6000', '6007'),
('6000', '6101'),
('6000', '6102'),
('6000', '6103'),
('6000', '6104'),
('6000', '6105'),
('6000', '6106'),
('6000', '6201'),
('6000', '6202'),
('6000', '6203'),
('6000', '6301'),
('7000', '7000'),
('8000', '8000');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `Tbl_permisos_aplicacion_perfil` 
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '3000', '1', '1', '1', '1', '1'),
('1', '5000', '1', '1', '1', '1', '1'),
('1', '6000', '1', '1', '1', '1', '1'),
('1', '6001', '1', '1', '1', '1', '1'),
('1', '6002', '1', '1', '1', '1', '1'),
('1', '6003', '1', '1', '1', '1', '1'),
('1', '6004', '1', '1', '1', '1', '1'),
('1', '6005', '1', '1', '1', '1', '1'),
('1', '6006', '1', '1', '1', '1', '1'),
('1', '6007', '1', '1', '1', '1', '1'),
('1', '6101', '1', '1', '1', '1', '1'),
('1', '6102', '1', '1', '1', '1', '1'),
('1', '6103', '1', '1', '1', '1', '1'),
('1', '6104', '1', '1', '1', '1', '1'),
('1', '6105', '1', '1', '1', '1', '1'),
('1', '6106', '1', '1', '1', '1', '1'),
('1', '6201', '1', '1', '1', '1', '1'),
('1', '6202', '1', '1', '1', '1', '1'),
('1', '6203', '1', '1', '1', '1', '1'),
('1', '6301', '1', '1', '1', '1', '1'),
('1', '7000', '1', '1', '1', '1', '1'),
('1', '8000', '1', '1', '1', '1', '1'),
('2', '1000', '1', '1', '1', '1', '1'),
('3', '2000', '1', '1', '1', '1', '1'),
('4', '3000', '1', '1', '1', '1', '1'),
('5', '5000', '1', '1', '1', '1', '1'),
('6', '6000', '1', '1', '1', '1', '1'),
('6', '6001', '1', '1', '1', '1', '1'),
('6', '6002', '1', '1', '1', '1', '1'),
('6', '6003', '1', '1', '1', '1', '1'),
('6', '6004', '1', '1', '1', '1', '1'),
('6', '6005', '1', '1', '1', '1', '1'),
('6', '6006', '1', '1', '1', '1', '1'),
('6', '6007', '1', '1', '1', '1', '1'),
('6', '6101', '1', '1', '1', '1', '1'),
('6', '6102', '1', '1', '1', '1', '1'),
('6', '6103', '1', '1', '1', '1', '1'),
('6', '6104', '1', '1', '1', '1', '1'),
('6', '6105', '1', '1', '1', '1', '1'),
('6', '6106', '1', '1', '1', '1', '1'),
('6', '6201', '1', '1', '1', '1', '1'),
('6', '6202', '1', '1', '1', '1', '1'),
('6', '6203', '1', '1', '1', '1', '1'),
('6', '6301', '1', '1', '1', '1', '1'),
('7', '7000', '1', '1', '1', '1', '1'),
('8', '8000', '1', '1', '1', '1', '1');


INSERT INTO `Tbl_asignaciones_perfils_usuario` 
(Fk_id_usuario,Fk_id_perfil)
VALUES
('1', '1'); 


-- -----CREACION DE NUEVOS ROLES (carlos.H)
-- Insertar nuevos roles en la tabla Tbl_perfiles
INSERT INTO `Tbl_perfiles` VALUES
('9', 'AUDITOR', 'Permite la revisión y auditoría de actividades sin capacidad de modificar datos', 1),
('10', 'SOporte Técnico', 'Permite brindar asistencia técnica sin acceso completo a la administración', 1),
('11', 'ADMINISTRADOR', 'Acceso completo al sistema con ciertas restricciones según sea necesario', 1),
('12', 'GESTOR DE PROYECTOS', 'Permite gestionar proyectos y coordinar actividades sin acceso completo a la administración', 1),
('13', 'GESTOR DE DATOS', 'Permite gestionar y supervisar datos en distintos módulos sin acceso completo a la administración', 1);

-- Asignar permisos de aplicaciones a los nuevos perfiles

-- Auditor
INSERT INTO `Tbl_permisos_aplicacion_perfil` 
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES
('9', '1000', '1', '1', '1', '1', '1'),
('9', '1001', '1', '1', '1', '1', '1'),
('9', '1002', '1', '1', '1', '1', '1'),
('9', '1003', '1', '1', '1', '1', '1'),
('9', '1004', '1', '1', '1', '1', '1'),
('9', '1101', '1', '1', '1', '1', '1'),
('9', '1102', '1', '1', '1', '1', '1'),
('9', '1103', '1', '1', '1', '1', '1'),
('9', '1201', '1', '1', '1', '1', '1'),
('9', '1301', '1', '1', '1', '1', '1'),
('9', '2000', '1', '1', '1', '1', '1'),
('9', '3000', '1', '1', '1', '1', '1'),
('9', '5000', '1', '1', '1', '1', '1'),
('9', '6000', '1', '1', '1', '1', '1'),
('9', '6001', '1', '1', '1', '1', '1'),
('9', '6002', '1', '1', '1', '1', '1'),
('9', '6003', '1', '1', '1', '1', '1'),
('9', '6004', '1', '1', '1', '1', '1'),
('9', '6005', '1', '1', '1', '1', '1'),
('9', '6006', '1', '1', '1', '1', '1'),
('9', '6007', '1', '1', '1', '1', '1'),
('9', '6101', '1', '1', '1', '1', '1'),
('9', '6102', '1', '1', '1', '1', '1'),
('9', '6103', '1', '1', '1', '1', '1'),
('9', '6104', '1', '1', '1', '1', '1'),
('9', '6105', '1', '1', '1', '1', '1'),
('9', '6106', '1', '1', '1', '1', '1'),
('9', '6201', '1', '1', '1', '1', '1'),
('9', '6202', '1', '1', '1', '1', '1'),
('9', '6203', '1', '1', '1', '1', '1'),
('9', '6301', '1', '1', '1', '1', '1'),
('9', '7000', '1', '1', '1', '1', '1'),
('9', '8000', '1', '1', '1', '1', '1');

-- Soporte Técnico
INSERT INTO `Tbl_permisos_aplicacion_perfil`
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES 
('10', '1000', '1', '1', '1', '1', '1'),
('10', '1001', '1', '1', '1', '1', '1'),
('10', '1002', '1', '1', '1', '1', '1'),
('10', '1003', '1', '1', '1', '1', '1'),
('10', '1004', '1', '1', '1', '1', '1'),
('10', '1101', '1', '1', '1', '1', '1'),
('10', '1102', '1', '1', '1', '1', '1'),
('10', '1103', '1', '1', '1', '1', '1'),
('10', '1201', '1', '1', '1', '1', '1'),
('10', '1301', '1', '1', '1', '1', '1'),
('10', '2000', '1', '1', '1', '1', '1'),
('10', '3000', '1', '1', '1', '1', '1'),
('10', '5000', '1', '1', '1', '1', '1'),
('10', '6000', '1', '1', '1', '1', '1'),
('10', '6001', '1', '1', '1', '1', '1'),
('10', '6002', '1', '1', '1', '1', '1'),
('10', '6003', '1', '1', '1', '1', '1'),
('10', '6004', '1', '1', '1', '1', '1'),
('10', '6005', '1', '1', '1', '1', '1'),
('10', '6006', '1', '1', '1', '1', '1'),
('10', '6007', '1', '1', '1', '1', '1'),
('10', '6101', '1', '1', '1', '1', '1'),
('10', '6102', '1', '1', '1', '1', '1'),
('10', '6103', '1', '1', '1', '1', '1'),
('10', '6104', '1', '1', '1', '1', '1'),
('10', '6105', '1', '1', '1', '1', '1'),
('10', '6106', '1', '1', '1', '1', '1'),
('10', '6201', '1', '1', '1', '1', '1'),
('10', '6202', '1', '1', '1', '1', '1'),
('10', '6203', '1', '1', '1', '1', '1'),
('10', '6301', '1', '1', '1', '1', '1'),
('10', '7000', '1', '1', '1', '1', '1'),
('10', '8000', '1', '1', '1', '1', '1');

-- Administrador
INSERT INTO `Tbl_permisos_aplicacion_perfil` 
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES
('11', '1000', '1', '1', '1', '1', '1'),
('11', '1001', '1', '1', '1', '1', '1'),
('11', '1002', '1', '1', '1', '1', '1'),
('11', '1003', '1', '1', '1', '1', '1'),
('11', '1004', '1', '1', '1', '1', '1'),
('11', '1101', '1', '1', '1', '1', '1'),
('11', '1102', '1', '1', '1', '1', '1'),
('11', '1103', '1', '1', '1', '1', '1'),
('11', '1201', '1', '1', '1', '1', '1'),
('11', '1301', '1', '1', '1', '1', '1'),
('11', '2000', '1', '1', '1', '1', '1'),
('11', '3000', '1', '1', '1', '1', '1'),
('11', '5000', '1', '1', '1', '1', '1'),
('11', '6000', '1', '1', '1', '1', '1'),
('11', '6001', '1', '1', '1', '1', '1'),
('11', '6002', '1', '1', '1', '1', '1'),
('11', '6003', '1', '1', '1', '1', '1'),
('11', '6004', '1', '1', '1', '1', '1'),
('11', '6005', '1', '1', '1', '1', '1'),
('11', '6006', '1', '1', '1', '1', '1'),
('11', '6007', '1', '1', '1', '1', '1'),
('11', '6101', '1', '1', '1', '1', '1'),
('11', '6102', '1', '1', '1', '1', '1'),
('11', '6103', '1', '1', '1', '1', '1'),
('11', '6104', '1', '1', '1', '1', '1'),
('11', '6105', '1', '1', '1', '1', '1'),
('11', '6106', '1', '1', '1', '1', '1'),
('11', '6201', '1', '1', '1', '1', '1'),
('11', '6202', '1', '1', '1', '1', '1'),
('11', '6203', '1', '1', '1', '1', '1'),
('11', '6301', '1', '1', '1', '1', '1'),
('11', '7000', '1', '1', '1', '1', '1'),
('11', '8000', '1', '1', '1', '1', '1');

-- Gestor de Proyectos
INSERT INTO `Tbl_permisos_aplicacion_perfil` 
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES
('12', '1000', '1', '1', '1', '1', '1'),
('12', '1001', '1', '1', '1', '1', '1'),
('12', '1002', '1', '1', '1', '1', '1'),
('12', '1003', '1', '1', '1', '1', '1'),
('12', '1004', '1', '1', '1', '1', '1'),
('12', '1101', '1', '1', '1', '1', '1'),
('12', '1102', '1', '1', '1', '1', '1'),
('12', '1103', '1', '1', '1', '1', '1'),
('12', '1201', '1', '1', '1', '1', '1'),
('12', '1301', '1', '1', '1', '1', '1'),
('12', '2000', '1', '1', '1', '1', '1'),
('12', '3000', '1', '1', '1', '1', '1'),
('12', '5000', '1', '1', '1', '1', '1'),
('12', '6000', '1', '1', '1', '1', '1'),
('12', '6001', '1', '1', '1', '1', '1'),
('12', '6002', '1', '1', '1', '1', '1'),
('12', '6003', '1', '1', '1', '1', '1'),
('12', '6004', '1', '1', '1', '1', '1'),
('12', '6005', '1', '1', '1', '1', '1'),
('12', '6006', '1', '1', '1', '1', '1'),
('12', '6007', '1', '1', '1', '1', '1'),
('12', '6101', '1', '1', '1', '1', '1'),
('12', '6102', '1', '1', '1', '1', '1'),
('12', '6103', '1', '1', '1', '1', '1'),
('12', '6104', '1', '1', '1', '1', '1'),
('12', '6105', '1', '1', '1', '1', '1'),
('12', '6106', '1', '1', '1', '1', '1'),
('12', '6201', '1', '1', '1', '1', '1'),
('12', '6202', '1', '1', '1', '1', '1'),
('12', '6203', '1', '1', '1', '1', '1'),
('12', '6301', '1', '1', '1', '1', '1'),
('12', '7000', '1', '1', '1', '1', '1'),
('12', '8000', '1', '1', '1', '1', '1');

-- Gestor de Datos
INSERT INTO `Tbl_permisos_aplicacion_perfil`
(`Fk_id_perfil`, `Fk_id_aplicacion`, `guardar_permiso`, `modificar_permiso`, `eliminar_permiso`, `buscar_permiso`, `imprimir_permiso`)
VALUES
('13', '1000', '1', '1', '1', '1', '1'),
('13', '1001', '1', '1', '1', '1', '1'),
('13', '1002', '1', '1', '1', '1', '1'),
('13', '1003', '1', '1', '1', '1', '1'),
('13', '1004', '1', '1', '1', '1', '1'),
('13', '1101', '1', '1', '1', '1', '1'),
('13', '1102', '1', '1', '1', '1', '1'),
('13', '1103', '1', '1', '1', '1', '1'),
('13', '1201', '1', '1', '1', '1', '1'),
('13', '1301', '1', '1', '1', '1', '1'),
('13', '2000', '1', '1', '1', '1', '1'),
('13', '3000', '1', '1', '1', '1', '1'),
('13', '5000', '1', '1', '1', '1', '1'),
('13', '6000', '1', '1', '1', '1', '1'),
('13', '6001', '1', '1', '1', '1', '1'),
('13', '6002', '1', '1', '1', '1', '1'),
('13', '6003', '1', '1', '1', '1', '1'),
('13', '6004', '1', '1', '1', '1', '1'),
('13', '6005', '1', '1', '1', '1', '1'),
('13', '6006', '1', '1', '1', '1', '1'),
('13', '6007', '1', '1', '1', '1', '1'),
('13', '6101', '1', '1', '1', '1', '1'),
('13', '6102', '1', '1', '1', '1', '1'),
('13', '6103', '1', '1', '1', '1', '1'),
('13', '6104', '1', '1', '1', '1', '1'),
('13', '6105', '1', '1', '1', '1', '1'),
('13', '6106', '1', '1', '1', '1', '1'),
('13', '6201', '1', '1', '1', '1', '1'),
('13', '6202', '1', '1', '1', '1', '1'),
('13', '6203', '1', '1', '1', '1', '1'),
('13', '6301', '1', '1', '1', '1', '1'),
('13', '7000', '1', '1', '1', '1', '1'),
('13', '8000', '1', '1', '1', '1', '1');


-- *********Ingreso tbl_permisos_aplicaciones_usuario******************
-- Pruebas IsmarCortez
-- select* from tbl_usuarios;
-- select* from tbl_aplicaciones;
-- select* from tbl_permisos_aplicaciones_usuario;


-- INSERT INTO `tbl_permisos_aplicaciones_usuario` VALUES
-- ('1000', '1', '1', '1', '1', '1', '1');

-- INSERT INTO `tbl_permisos_aplicaciones_usuario` VALUES
-- ('1000', '7', '0', '0', '0', '0', '1');

-- *********************************************************************

-- use seguridad;

-- ***************************Permiso de (GUARDAR)****************************************************
-- Select guardar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario=1 AND Fk_id_aplicacion =1000;

-- Select Tbl_permisos_aplicacion_perfil.guardar_permiso from Tbl_permisos_aplicacion_perfil 
-- INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil
-- WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario=1 AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion =1000;

-- select* from Tbl_permisos_aplicaciones_usuario;
-- ***************************************************************************************************

-- ***************************Permiso de (Buscar)****************************************************
-- Select buscar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario=1 AND Fk_id_aplicacion =1000;

-- Select Tbl_permisos_aplicacion_perfil.buscar_permiso from Tbl_permisos_aplicacion_perfil
-- INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil
-- WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario=1 AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion =1000;
-- ***************************************************************************************************

-- ***************************Permiso de (Modificar)****************************************************
-- Select modificar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario=1  AND Fk_id_aplicacion =1000;

-- Select Tbl_permisos_aplicacion_perfil.modificar_permiso from Tbl_permisos_aplicacion_perfil
-- INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil
-- WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario=1 AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion =1000 ;
 
-- ***************************************************************************************************

-- ***************************Permiso de (eliminar)****************************************************
-- Select eliminar_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario=1 AND Fk_id_aplicacion = 1000;

-- Select Tbl_permisos_aplicacion_perfil.eliminar_permiso from Tbl_permisos_aplicacion_perfil 
-- INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil
-- WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario=1  AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion =1000;
-- ***************************************************************************************************

-- ***************************Permiso de (Imprimir)****************************************************
-- Select imprimir_permiso from Tbl_permisos_aplicaciones_usuario WHERE Fk_id_usuario=1 AND Fk_id_aplicacion =1000;

-- Select Tbl_permisos_aplicacion_perfil.imprimir_permiso from Tbl_permisos_aplicacion_perfil
-- INNER JOIN Tbl_asignaciones_perfils_usuario ON Tbl_permisos_aplicacion_perfil.Fk_id_perfil = Tbl_asignaciones_perfils_usuario.Fk_id_perfil
-- WHERE Tbl_asignaciones_perfils_usuario.Fk_id_usuario=1 AND Tbl_permisos_aplicacion_perfil.Fk_id_aplicacion =1000

-- ***************************************************************************************************
