-- 1. Creación de tabla maquinaria, hablada con el ingeniero.
CREATE TABLE IF NOT EXISTS `tbl_maquinaria` (
  `pk_id_maquina` int(11) AUTO_INCREMENT PRIMARY KEY,
  `nombre_maquina` varchar(100) NOT NULL,
  `tipo_maquina` varchar(50) NOT NULL,
  `capacidad_produccion` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- 2. Alter para añadir la foránea a la tabla de mantenimiento
ALTER TABLE `tbl_mantenimientos`
ADD COLUMN `fk_id_maquina` int(11) NOT NULL;

ALTER TABLE `tbl_mantenimientos`
ADD CONSTRAINT `fk_maquina`
FOREIGN KEY (`fk_id_maquina`) REFERENCES `tbl_maquinaria`(`pk_id_maquina`);

