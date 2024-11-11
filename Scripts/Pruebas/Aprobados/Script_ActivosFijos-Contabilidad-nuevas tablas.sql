DROP TABLE IF EXISTS `tbl_ActivoFijo`;

-- Creación de la tabla `tbl_TipoActivoFijo`
CREATE TABLE IF NOT EXISTS `tbl_TipoActivoFijo` (
  `Pk_Id_TipoActivoFijo` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Tipo` VARCHAR(50) NOT NULL,
  `Estado` TINYINT(4) NOT NULL,
  PRIMARY KEY (`Pk_Id_TipoActivoFijo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_IdentidadActivo` (
  `Pk_Id_Identidad` INT(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Identidad` VARCHAR(50) NOT NULL,
  `Estado` TINYINT(4) NOT NULL,
  PRIMARY KEY (`Pk_Id_Identidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ActivoFijo` (
  `Pk_Id_ActivoFijo` INT(11) NOT NULL AUTO_INCREMENT,
  `Codigo_Activo` VARCHAR(50) NOT NULL UNIQUE,
  `Pk_Id_TipoActivoFijo` INT(11) DEFAULT NULL,
  `Descripcion` VARCHAR(255) NOT NULL,
  `Pk_Id_Identidad` INT(11) DEFAULT NULL,
  `Modelo` VARCHAR(100) DEFAULT NULL,
  `Fecha_Adquisicion` DATE DEFAULT NULL,
  `Costo_Adquisicion` DECIMAL(10,2) DEFAULT NULL,
  `Vida_Util` DECIMAL(5,2) DEFAULT NULL,
  `Valor_Residual` DECIMAL(10,2) DEFAULT NULL,
  `Estado` TINYINT(4) DEFAULT NULL,
  `Pk_Id_Cuenta` INT(11) NOT NULL,
  PRIMARY KEY (`Pk_Id_ActivoFijo`),
  KEY `Fk_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`),
  KEY `Fk_Identidad` (`Pk_Id_Identidad`),
  KEY `Fk_Cuenta` (`Pk_Id_Cuenta`),
  CONSTRAINT `Fk_TipoActivoFijo_New` FOREIGN KEY (`Pk_Id_TipoActivoFijo`) REFERENCES `tbl_TipoActivoFijo` (`Pk_Id_TipoActivoFijo`) ON DELETE SET NULL,
  CONSTRAINT `Fk_Identidad_New` FOREIGN KEY (`Pk_Id_Identidad`) REFERENCES `tbl_IdentidadActivo` (`Pk_Id_Identidad`) ON DELETE SET NULL,
  CONSTRAINT `Fk_Cuenta_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_Cuentas` (`Pk_Id_Cuenta`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- Creación de la tabla `tbl_Depreciacion_ActivoFijo`
CREATE TABLE IF NOT EXISTS `tbl_Depreciacion_ActivoFijo` (
  `Pk_Id_Depreciacion` INT(11) NOT NULL AUTO_INCREMENT,
  `Pk_Id_ActivoFijo` INT(11) NOT NULL,
  `Nombre_Activo` VARCHAR(100) NOT NULL,
  `Tipo_Activo` VARCHAR(50) NOT NULL,
  `Encargado` VARCHAR(100) DEFAULT NULL,
  `Departamento` VARCHAR(100) DEFAULT NULL,
  `Fecha_Depreciacion` DATE DEFAULT NULL,
  `Depreciacion` DECIMAL(10,2) DEFAULT NULL,
  `Depreciacion_Fiscal` DECIMAL(10,2) DEFAULT NULL,
  `Descripcion` VARCHAR(255) DEFAULT NULL,
  `Estado` TINYINT(4) DEFAULT NULL,
  `Pk_Id_Cuenta` INT(11) NOT NULL,
  PRIMARY KEY (`Pk_Id_Depreciacion`),
  CONSTRAINT `Fk_IdActivoFijo_Depreciacion` FOREIGN KEY (`Pk_Id_ActivoFijo`) REFERENCES `tbl_ActivoFijo` (`Pk_Id_ActivoFijo`) ON DELETE CASCADE,
  CONSTRAINT `Fk_Cuenta_Depreciacion_New` FOREIGN KEY (`Pk_Id_Cuenta`) REFERENCES `tbl_Cuentas` (`Pk_Id_Cuenta`) ON DELETE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;