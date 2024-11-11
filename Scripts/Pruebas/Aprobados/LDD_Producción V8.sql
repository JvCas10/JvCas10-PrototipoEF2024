CREATE TABLE IF NOT EXISTS `tbl_cierre_produccion` (
  `pk_id_cierre` int(11) NOT NULL,
  `fecha` date NOT NULL,
  `saldo_anterior` decimal(10,2) NOT NULL,
  `cargos_mes` decimal(10,2) NOT NULL,
  `abonos_mes` decimal(10,2) NOT NULL,
  `saldo_actual` decimal(10,2) NOT NULL,
  `cargos_acumulados` decimal(10,2) NOT NULL,
  `abonos_acumulados` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_conversiones` (
  `id_conversion` int(11) NOT NULL,
  `unidad_origen` varchar(50) NOT NULL,
  `unidad_destino` varchar(50) NOT NULL,
  `factor_conversion` decimal(10,6) NOT NULL,
  `tipo_conversion` varchar(50) NOT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_detalles` (
  `Pk_id_lotes_detalle` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `Fk_id_lote` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_lotes_encabezado` (
  `Pk_id_lote` int(11) NOT NULL,
  `codigo_lote` varchar(100) DEFAULT NULL,
  `Fecha_Producción` date DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_mantenimientos` (
  `Pk_id_maquinaria` int(11) NOT NULL,
  `nombre_maquinaria` varchar(255) DEFAULT NULL,
  `tipo_maquina` varchar(255) DEFAULT NULL,
  `hora_operacion` decimal(10,2) DEFAULT NULL,
  `mantenimiento_periodico` varchar(100) DEFAULT NULL,
  `ultima_mantenimiento` date DEFAULT NULL,
  `proximo_mantenimiento` date DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `desgaste_porcentaje` decimal(10,2) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion` (
  `Pk_id_orden` int(11) NOT NULL,
  `fecha_inicio` date DEFAULT NULL,
  `fecha_fin` date DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_ordenes_produccion_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_orden` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_detalle` (
  `Pk_id_proceso_detalle` int(11) NOT NULL,
  `Fk_id_productos` int(11) DEFAULT NULL,
  `Fk_id_receta` int(11) DEFAULT NULL,
  `Fk_id_empleado` int(11) DEFAULT NULL,
  `Fk_id_proceso` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `costo_u` decimal(10,2) DEFAULT NULL,
  `costo_t` decimal(10,2) DEFAULT NULL,
  `duracion_horas` decimal(10,2) DEFAULT NULL,
  `mano_de_obra` decimal(10,2) DEFAULT NULL,
  `costo_luz` decimal(10,2) DEFAULT NULL,
  `costo_agua` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_proceso_produccion_encabezado` (
  `Pk_id_proceso` int(11) NOT NULL,
  `Fk_id_orden` int(11) DEFAULT NULL,
  `Fk_id_maquinaria` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_recetas` (
  `Pk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) DEFAULT NULL,
  `descripcion` varchar(255) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `area` varchar(100) DEFAULT NULL,
  `cama` varchar(100) DEFAULT NULL,
  `estado` tinyint(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_receta_detalle` (
  `Pk_id_detalle` int(11) NOT NULL,
  `Fk_id_receta` int(11) NOT NULL,
  `Fk_id_producto` int(11) NOT NULL,
  `cantidad` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

CREATE TABLE IF NOT EXISTS `tbl_rrhh_produccion` (
  `id_RRHH` int(10) UNSIGNED NOT NULL,
  `id_empleado` int(11) NOT NULL,
  `id_contrato` int(11) NOT NULL,
  `dias` int(11) NOT NULL,
  `total_dias` decimal(10,2) NOT NULL,
  `horas` decimal(10,2) NOT NULL,
  `total_horas` decimal(10,2) NOT NULL,
  `id_hora_extra` int(11) DEFAULT NULL,
  `total_horas_extras` decimal(10,2) DEFAULT NULL,
  `total_mano_obra` decimal(10,2) NOT NULL,
  `estado` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
