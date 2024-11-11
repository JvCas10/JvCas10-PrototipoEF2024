-- Alteraciones para asegurar integridad y consistencia con el script principal

-- **1. Añadir claves primarias y auto-incrementos a las tablas referenciadas**

-- Primero, aseguramos que `tbl_recetas` tenga su clave primaria definida
ALTER TABLE `tbl_recetas`
    ADD PRIMARY KEY (`Pk_id_receta`),
    MODIFY `Pk_id_receta` int(11) NOT NULL AUTO_INCREMENT;

-- Luego, definimos la clave primaria en `tbl_cierre_produccion`
ALTER TABLE `tbl_cierre_produccion`
    ADD PRIMARY KEY (`pk_id_cierre`),
    MODIFY `pk_id_cierre` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_conversiones`
ALTER TABLE `tbl_conversiones`
    ADD PRIMARY KEY (`id_conversion`),
    MODIFY `id_conversion` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_mantenimientos`
ALTER TABLE `tbl_mantenimientos`
    ADD PRIMARY KEY (`Pk_id_maquinaria`),
    MODIFY `Pk_id_maquinaria` int(11) NOT NULL AUTO_INCREMENT;

-- Definimos la clave primaria en `tbl_ordenes_produccion`
ALTER TABLE `tbl_ordenes_produccion`
    ADD PRIMARY KEY (`Pk_id_orden`),
    MODIFY `Pk_id_orden` int(11) NOT NULL AUTO_INCREMENT;

-- **2. Añadir claves foráneas y índices en las tablas que referencian a otras**

-- Tabla `tbl_proceso_produccion_encabezado`
ALTER TABLE `tbl_proceso_produccion_encabezado`
    ADD PRIMARY KEY (`Pk_id_proceso`),
    MODIFY `Pk_id_proceso` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_maquinaria` (`Fk_id_maquinaria`),
    ADD CONSTRAINT `fk_orden_proceso_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_maquinaria_proceso_produccion` FOREIGN KEY (`Fk_id_maquinaria`) REFERENCES `tbl_mantenimientos` (`Pk_id_maquinaria`);

-- Tabla `tbl_lotes_encabezado`
ALTER TABLE `tbl_lotes_encabezado`
    ADD PRIMARY KEY (`Pk_id_lote`),
    MODIFY `Pk_id_lote` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_proceso_lote_encabezado` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_proceso_lote_encabezado` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- Tabla `tbl_lotes_detalles`
ALTER TABLE `tbl_lotes_detalles`
    ADD PRIMARY KEY (`Pk_id_lotes_detalle`),
    MODIFY `Pk_id_lotes_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD INDEX `idx_fk_lote` (`Fk_id_lote`),
    ADD CONSTRAINT `fk_producto_lotes_detalles` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_lote_lotes_detalles` FOREIGN KEY (`Fk_id_lote`) REFERENCES `tbl_lotes_encabezado` (`Pk_id_lote`);

-- Tabla `tbl_ordenes_produccion_detalle`
ALTER TABLE `tbl_ordenes_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_orden` (`Fk_id_orden`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_orden_detalle_produccion` FOREIGN KEY (`Fk_id_orden`) REFERENCES `tbl_ordenes_produccion` (`Pk_id_orden`),
    ADD CONSTRAINT `fk_producto_detalle_produccion` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_receta_detalle`
ALTER TABLE `tbl_receta_detalle`
    ADD PRIMARY KEY (`Pk_id_detalle`),
    MODIFY `Pk_id_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_producto` (`Fk_id_producto`),
    ADD CONSTRAINT `fk_receta_detalle` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_producto_receta_detalle` FOREIGN KEY (`Fk_id_producto`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`);

-- Tabla `tbl_proceso_produccion_detalle`
ALTER TABLE `tbl_proceso_produccion_detalle`
    ADD PRIMARY KEY (`Pk_id_proceso_detalle`),
    MODIFY `Pk_id_proceso_detalle` int(11) NOT NULL AUTO_INCREMENT,
    ADD INDEX `idx_fk_productos` (`Fk_id_productos`),
    ADD INDEX `idx_fk_receta` (`Fk_id_receta`),
    ADD INDEX `idx_fk_empleado` (`Fk_id_empleado`),
    ADD INDEX `idx_fk_proceso` (`Fk_id_proceso`),
    ADD CONSTRAINT `fk_productos_proceso_produccion` FOREIGN KEY (`Fk_id_productos`) REFERENCES `Tbl_Productos` (`Pk_id_Producto`),
    ADD CONSTRAINT `fk_receta_proceso_produccion` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`),
    ADD CONSTRAINT `fk_empleado_proceso_produccion` FOREIGN KEY (`Fk_id_empleado`) REFERENCES `tbl_empleados` (`pk_clave`),
    ADD CONSTRAINT `fk_proceso_produccion` FOREIGN KEY (`Fk_id_proceso`) REFERENCES `tbl_proceso_produccion_encabezado` (`Pk_id_proceso`);

-- **3. Integración de claves foráneas en tablas existentes**

-- Aseguramos que `tbl_cierre_produccion` tenga su clave primaria antes de ser referenciada
ALTER TABLE `tbl_cuentas`
    ADD COLUMN `Fk_id_cierre_produccion` INT(11),
    ADD INDEX `idx_fk_cierre_produccion` (`Fk_id_cierre_produccion`),
    ADD CONSTRAINT `fk_cierre_produccion` FOREIGN KEY (`Fk_id_cierre_produccion`) REFERENCES `tbl_cierre_produccion` (`pk_id_cierre`);

-- Aseguramos que `tbl_recetas` tenga su clave primaria antes de ser referenciada
ALTER TABLE `Tbl_Productos`
    ADD COLUMN `Fk_id_receta` INT(11),
    ADD INDEX `idx_fk_receta_producto` (`Fk_id_receta`),
    ADD CONSTRAINT `fk_receta_producto` FOREIGN KEY (`Fk_id_receta`) REFERENCES `tbl_recetas` (`Pk_id_receta`);
