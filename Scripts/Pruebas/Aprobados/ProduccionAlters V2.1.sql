-- 1. Dropeo de columnas
ALTER TABLE tbl_rrhh_produccion 
DROP COLUMN id_empleado,
DROP COLUMN id_contrato,
DROP COLUMN dias,
DROP COLUMN total_dias,
DROP COLUMN horas,
DROP COLUMN total_horas,
DROP COLUMN id_hora_extra,
DROP COLUMN total_horas_extras,
DROP COLUMN total_mano_obra,
DROP COLUMN estado;

-- 2. Se agregan las columnas
ALTER TABLE tbl_rrhh_produccion 
ADD COLUMN id_empleado INT NOT NULL,
ADD COLUMN salario DECIMAL(10, 2) NOT NULL,
ADD COLUMN dias INT NOT NULL,
ADD COLUMN total_dias DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas INT NOT NULL,
ADD COLUMN total_horas DECIMAL(10, 2) NOT NULL,
ADD COLUMN horas_extras INT NOT NULL,
ADD COLUMN total_horas_extras DECIMAL(10, 2) NOT NULL,
ADD COLUMN total_mano_obra DECIMAL(10, 2) NOT NULL,
ADD COLUMN estado TINYINT(1) NOT NULL;

-- 3. Se dropea la columna id_RRHH
ALTER TABLE tbl_rrhh_produccion
DROP COLUMN id_RRHH;

-- 4. Se agrega el pk correcto
ALTER TABLE tbl_rrhh_produccion
ADD COLUMN pk_id_RRHH INT AUTO_INCREMENT PRIMARY KEY;
