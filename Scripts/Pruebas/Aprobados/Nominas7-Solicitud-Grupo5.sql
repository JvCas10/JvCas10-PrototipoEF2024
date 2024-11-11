-- create database nominas;
-- use nominas;
-- DROP DATABASE nominas;
-- use colchoneria;
DROP TABLE IF EXISTS tbl_planilla_Detalle;
DROP TABLE IF EXISTS tbl_planilla_Encabezado;
DROP TABLE IF EXISTS tbl_contratos;
DROP TABLE IF EXISTS tbl_horas_extra;
DROP TABLE IF EXISTS tbl_control_anticipos;
DROP TABLE IF EXISTS tbl_control_faltas;
DROP TABLE IF EXISTS tbl_Liquidacion_Trabajadores;
DROP TABLE IF EXISTS tbl_dedu_perp_emp;
DROP TABLE IF EXISTS tbl_asignacion_vacaciones;
DROP TABLE IF EXISTS tbl_empleados;
DROP TABLE IF EXISTS tbl_puestos_trabajo;
DROP TABLE IF EXISTS tbl_departamentos;
DROP TABLE IF EXISTS tbl_dedu_perp;
DROP TABLE IF EXISTS tbl_empresas;
DROP TABLE IF EXISTS tbl_polizas;

CREATE TABLE tbl_puestos_trabajo (
	pk_id_puestos INT NOT NULL AUTO_INCREMENT,
    puestos_nombre_puesto VARCHAR(50),
    puestos_descripcion  VARCHAR(50),
    primary key (`pk_id_puestos`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_departamentos (
	pk_id_departamento  INT NOT NULL AUTO_INCREMENT,
    departamentos_nombre_departamento VARCHAR(50),
    departamentos_descripcion  VARCHAR(50) NOT NULL,
    primary key (`pk_id_departamento`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE IF NOT EXISTS tbl_empleados (
	pk_clave INT NOT NULL AUTO_INCREMENT,
    empleados_nombre VARCHAR(50) NOT NULL,
    empleados_apellido  VARCHAR(50),
    empleados_fecha_nacimiento  date,
    empleados_no_identificacion  VARCHAR(50) NOT NULL,
    empleados_codigo_postal  VARCHAR(50),
    empleados_fecha_alta  date,
    empleados_fecha_baja date,
    empleados_causa_baja  VARCHAR(50),
    fk_id_departamento INT NOT NULL, 
    fk_id_puestos INT NOT NULL, 
	FOREIGN KEY (`fk_id_departamento`) REFERENCES `tbl_departamentos` (`pk_id_departamento`),
    FOREIGN KEY (`fk_id_puestos`) REFERENCES `tbl_puestos_trabajo` (`pk_id_puestos`), 
	primary key (`pk_clave`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);
select* from tbl_empleados;
CREATE TABLE  tbl_asignacion_vacaciones (
	pk_registro_vaciones int auto_increment not null,
    asignacion_vacaciones_descripcion varchar(25),
    asignacion_vacaciones_fecha_inicio date,
    asignacion_vacaciones_fecha_fin date,
    fk_clave_empleado INT NOT NULL, 
    estado TINYINT(1) NOT NULL DEFAULT 1,
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_vaciones`)
);

CREATE TABLE  tbl_contratos (
	pk_id_contrato INT NOT NULL AUTO_INCREMENT,
    contratos_fecha_creacion date NOT NULL,
    contratos_salario  decimal(10,2) NOT NULL,
    contratos_tipo_contrato varchar(35), 
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_id_contrato`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_horas_extra (
	pk_registro_horas INT NOT NULL AUTO_INCREMENT,
    horas_mes varchar(25),
    horas_cantidad_horas decimal(10,2),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_horas`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_control_anticipos (
	pk_registro_anticipos INT NOT NULL AUTO_INCREMENT,
    anticipos_cantidad decimal(10,2),
    anticipos_descripcion varchar(50),
    anticipos_mes varchar(25),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_anticipos`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_control_faltas (
	pk_registro_faltas INT NOT NULL AUTO_INCREMENT,
    faltas_fecha_falta date,
    faltas_mes varchar(25),
    faltas_justificacion varchar(25),
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_faltas`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE tbl_Liquidacion_Trabajadores (
	pk_registro_liquidacion INT NOT NULL AUTO_INCREMENT,
    liquidacion_aguinaldo decimal (10,2) not null,
    liquidacion_bono_14 decimal (10,2) not null,
    liquidacion_vacaciones decimal (10,2) not null,
    liquidacion_tipo_operacion varchar(25), 
    fk_clave_empleado INT NOT NULL, 
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    primary key (`pk_registro_liquidacion`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_planilla_Encabezado (
	pk_registro_planilla_Encabezado INT NOT NULL AUTO_INCREMENT,
    encabezado_correlativo_planilla int not null, 
    encabezado_fecha_inicio date,
    encabezado_fecha_final date,
    encabezado_total_mes decimal(10,2),
    primary key (`pk_registro_planilla_Encabezado`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE  tbl_planilla_Detalle (
	pk_registro_planilla_Detalle INT NOT NULL AUTO_INCREMENT,
    detalle_total_Percepciones decimal (10,2),
    detalle_total_Deducciones decimal(10,2),
    detalle_total_liquido decimal(10,2),
    fk_clave_empleado int not null, 
    fk_id_contrato int not null,
    fk_id_registro_planilla_Encabezado int not null,
    -- fk_registro_horas int not null,
    FOREIGN KEY (`fk_clave_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    FOREIGN KEY (`fk_id_contrato`) REFERENCES `tbl_contratos` (`pk_id_contrato`),
    FOREIGN KEY (`fk_id_registro_planilla_Encabezado`) REFERENCES `tbl_planilla_Encabezado` (`pk_registro_planilla_Encabezado`),
    primary key (`pk_registro_planilla_Detalle`),
    estado TINYINT(1) NOT NULL DEFAULT 1
);

CREATE TABLE tbl_dedu_perp (
    pk_dedu_perp INT NOT NULL AUTO_INCREMENT,
    dedu_perp_clase varchar(25),
    dedu_perp_concepto VARCHAR(25), -- IGSS, Vacaciones, Bonificacion Incentivo
    dedu_perp_tipo VARCHAR(25), -- Porcentaje o monton
    dedu_perp_aplicacion varchar(25), -- Todos, ninguno, etc
    dedu_perp_excepcion TINYINT(1), 
    dedu_perp_monto FLOAT,
    estado TINYINT(1),
    PRIMARY KEY ( pk_dedu_perp)
);

CREATE TABLE tbl_dedu_perp_emp (
    pk_dedu_perp_emp INT NOT NULL AUTO_INCREMENT,
    Fk_clave_empleado INT NOT NULL,
    Fk_dedu_perp INT NOT NULL,
    dedu_perp_emp_cantidad FLOAT, -- Este campo basicamente calculara la deduccion a la que se asocie el empleado
    -- Si es un % (como el IGSS) se multiplica el sueldo base (que lo tenemos en el contrato) por ese porcentaje(%)
    -- Si es un monto (que seria fijo cada mes, como Descuentos judiciales por ejemplo Q400, ese valor solo se copiara
    -- a "cantidad_deduccion"
    estado TINYINT(1),
    FOREIGN KEY (Fk_clave_empleado) REFERENCES tbl_empleados (pk_clave),
    FOREIGN KEY (Fk_dedu_perp ) REFERENCES tbl_dedu_perp (pk_dedu_perp),
    PRIMARY KEY (pk_dedu_perp_emp)
);

CREATE TABLE tbl_empresas (
    empresa_id INT AUTO_INCREMENT PRIMARY KEY,  -- Llave primaria autoincremental
    empresas_nombre VARCHAR(255) NOT NULL,       -- Nombre de la empresa
    empresas_logo LONGBLOB,                              -- Campo para almacenar la foto (logo) en formato binario
    empresas_fecha_creacion TIMESTAMP DEFAULT CURRENT_TIMESTAMP,  -- Campo para la fecha de creación
    empresas_direccion VARCHAR(255),                     -- Dirección de la empresa
    empresas_telefono VARCHAR(20),                       -- Número de teléfono de la empresa
    empresas_email VARCHAR(100),                         -- Correo electrónico de la empresa
    empresas_pagina_web VARCHAR(100),                     -- Página web de la empresa
    estado TINYINT(1)                          -- Estado de la empresa (activa/inactiva)
);







