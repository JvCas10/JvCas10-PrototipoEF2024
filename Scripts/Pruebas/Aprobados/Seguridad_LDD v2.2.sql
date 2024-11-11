DROP DATABASE  IF EXISTS `Colchoneria`;
CREATE DATABASE IF NOT EXISTS `Colchoneria`;
USE `Colchoneria`;

DROP TABLE IF EXISTS `Tbl_modulos`;
CREATE TABLE IF NOT EXISTS `Tbl_modulos` (
	Pk_id_modulos INT NOT NULL,
    nombre_modulo VARCHAR(50) NOT NULL,
    descripcion_modulo VARCHAR(150) NOT NULL,
    estado_modulo TINYINT DEFAULT 0,
    primary key (`Pk_id_modulos`)
);


DROP TABLE IF EXISTS `Tbl_aplicaciones`;
CREATE TABLE IF NOT EXISTS `Tbl_aplicaciones` (
	Pk_id_aplicacion INT NOT NULL,
    nombre_aplicacion VARCHAR(50) NOT NULL,
    descripcion_aplicacion VARCHAR(150) NOT NULL,
    estado_aplicacion TINYINT DEFAULT 0,
    primary key (`Pk_id_aplicacion`)
);

DROP TABLE IF EXISTS `Tbl_asignacion_modulo_aplicacion`;
CREATE TABLE IF NOT EXISTS `Tbl_asignacion_modulo_aplicacion` (
  Fk_id_modulos INT NOT NULL,
  Fk_id_aplicacion INT NOT NULL, 
  PRIMARY KEY (`Fk_id_modulos`,`Fk_id_aplicacion` ),
  FOREIGN KEY (`Fk_id_modulos`) REFERENCES `Tbl_modulos` (`Pk_id_modulos`),
  FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `Tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

CREATE TABLE tbl_regreporteria (
  idregistro int NOT NULL AUTO_INCREMENT,
  ruta varchar(500) NOT NULL,
  nombre_archivo varchar(45) NOT NULL,
  aplicacion varchar(45) NOT NULL,
  estado varchar(45) NOT NULL,
  Fk_id_aplicacion INT NOT NULL,
  Fk_id_modulos INT NOT NULL,
  PRIMARY KEY (idregistro),
  FOREIGN KEY (`Fk_id_modulos`) REFERENCES `Tbl_modulos` (`Pk_id_modulos`),
  FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `Tbl_aplicaciones` (`Pk_id_aplicacion`)
) ENGINE=InnoDB;


DROP TABLE IF EXISTS `Tbl_usuarios`;
CREATE TABLE IF NOT EXISTS `Tbl_usuarios` (
  Pk_id_usuario INT AUTO_INCREMENT NOT NULL,
  nombre_usuario VARCHAR(50) NOT NULL,
  apellido_usuario VARCHAR(50) NOT NULL,
  username_usuario VARCHAR(20) NOT NULL,
  password_usuario VARCHAR(100) NOT NULL,
  email_usuario VARCHAR(50) NOT NULL,
  ultima_conexion_usuario DATETIME NULL DEFAULT NULL,
  estado_usuario TINYINT DEFAULT 0 NOT NULL,
  pregunta varchar(50) not null,
  respuesta varchar(50) not null,
  PRIMARY KEY (`Pk_id_usuario`)
);

DROP TABLE IF EXISTS `Tbl_perfiles`;
CREATE TABLE IF NOT EXISTS `Tbl_perfiles` (
	Pk_id_perfil INT AUTO_INCREMENT NOT NULL,
    nombre_perfil VARCHAR(50) NOT NULL,
    descripcion_perfil VARCHAR(150) NOT NULL,
    estado_perfil TINYINT DEFAULT 0,
    primary key (Pk_id_perfil)
);

-- Karla Gómez 9959-21-1896
DROP TABLE IF EXISTS Tbl_permisos_aplicaciones_usuario;
CREATE TABLE IF NOT EXISTS Tbl_permisos_aplicaciones_usuario (
  PK_id_Aplicacion_Usuario INT NOT NULL AUTO_INCREMENT,
  Fk_id_usuario INT NOT NULL, 
  Fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (PK_id_Aplicacion_Usuario),
  FOREIGN KEY (Fk_id_usuario) REFERENCES Tbl_usuarios (Pk_id_usuario),
  FOREIGN KEY (Fk_id_aplicacion) REFERENCES Tbl_aplicaciones (Pk_id_aplicacion)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Karla Gómez 9959-21-1896
DROP TABLE IF EXISTS `Tbl_permisos_aplicacion_perfil`;
CREATE TABLE IF NOT EXISTS `Tbl_permisos_aplicacion_perfil` (
  PK_id_Aplicacion_Perfil INT NOT NULL AUTO_INCREMENT,
  Fk_id_perfil INT NOT NULL, 
  Fk_id_aplicacion INT NOT NULL, 
  guardar_permiso BOOLEAN DEFAULT FALSE,
  modificar_permiso BOOLEAN DEFAULT FALSE,
  eliminar_permiso BOOLEAN DEFAULT FALSE,
  buscar_permiso BOOLEAN DEFAULT FALSE,
  imprimir_permiso BOOLEAN DEFAULT FALSE,
  PRIMARY KEY (PK_id_Aplicacion_Perfil),
  FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `Tbl_aplicaciones` (`Pk_id_aplicacion`),
  FOREIGN KEY (`Fk_id_perfil`) REFERENCES `Tbl_perfiles` (`Pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- Karla Gómez 9959-21-1896
DROP TABLE IF EXISTS `Tbl_asignaciones_perfils_usuario`;
CREATE TABLE IF NOT EXISTS `Tbl_asignaciones_perfils_usuario` (
  PK_id_Perfil_Usuario INT NOT NULL AUTO_INCREMENT,
  Fk_id_usuario INT NOT NULL, 
  Fk_id_perfil INT NOT NULL,
  PRIMARY KEY (PK_id_Perfil_Usuario),
  FOREIGN KEY (`Fk_id_usuario`) REFERENCES `Tbl_usuarios` (`Pk_id_usuario`),
  FOREIGN KEY (`Fk_id_perfil`) REFERENCES `Tbl_perfiles` (`Pk_id_perfil`)
) ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

DROP TABLE IF EXISTS `Tbl_bitacora_de_eventos`;
CREATE TABLE IF NOT EXISTS `Tbl_bitacora_de_eventos` (
  Pk_id_bitacora INT AUTO_INCREMENT NOT NULL,
  Fk_id_usuario INT NOT NULL,
  Fk_id_aplicacion INT NOT NULL,
  fecha_bitacora DATE NOT NULL,
  hora_bitacora TIME NOT NULL,
  host_bitacora VARCHAR(45) NOT NULL,
  ip_bitacora VARCHAR(100) NOT NULL,
  accion_bitacora VARCHAR(200) NOT NULL,
  PRIMARY KEY (`Pk_id_bitacora`),
  FOREIGN KEY (`Fk_id_usuario`) REFERENCES `Tbl_usuarios` (`Pk_id_usuario`),
  FOREIGN KEY (`Fk_id_aplicacion`) REFERENCES `Tbl_aplicaciones` (`Pk_id_aplicacion`)
)ENGINE = InnoDB DEFAULT CHARACTER SET = utf8;

-- vistas ------------------------------------------------------------------------
CREATE 
VIEW `Seguridad`.`vwaplicacionperfil` AS 
    SELECT 
        `b`.`Fk_id_perfil` AS `ID`,
        `a`.`nombre_perfil` AS `Perfil`,
        `b`.`Fk_id_aplicacion` AS `Aplicacion`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Modificar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`Seguridad`.`Tbl_permisos_aplicacion_perfil` `b`
        JOIN `Seguridad`.`Tbl_perfiles` `a` ON ((`a`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)));
        
CREATE 
VIEW `Seguridad`.`vwaplicacionusuario` AS
    SELECT 
        `b`.`Fk_id_aplicacion` AS `Aplicacion`,
        `b`.`Fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `b`.`guardar_permiso` AS `Insertar`,
        `b`.`modificar_permiso` AS `Editar`,
        `b`.`eliminar_permiso` AS `Eliminar`,
        `b`.`buscar_permiso` AS `Buscar`,
        `b`.`imprimir_permiso` AS `Reporte`
    FROM
        (`Seguridad`.`Tbl_permisos_aplicaciones_usuario` `b`
        JOIN `Seguridad`.`Tbl_usuarios` `a` ON ((`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)));
        
CREATE 
VIEW `Seguridad`.`vwmoduloaplicacion` AS
    SELECT 
        `b`.`Fk_id_modulos` AS `ID`,
        `a`.`nombre_modulo` AS `Modulo`,
        `b`.`Fk_id_aplicacion` AS `Aplicacion`,
        `c`.`nombre_aplicacion` AS `Nombre`,
        `c`.`descripcion_aplicacion` AS `Descripcion`
    FROM
        ((`Seguridad`.`Tbl_asignacion_modulo_aplicacion` `b`
        JOIN `Seguridad`.`Tbl_modulos` `a` ON ((`a`.`Pk_id_modulos` = `b`.`Fk_id_modulos`)))
        JOIN `Seguridad`.`Tbl_aplicaciones` `c` ON ((`c`.`Pk_id_aplicacion` = `b`.`Fk_id_aplicacion`)));
        
CREATE 
VIEW `Seguridad`.`vwperfilusuario` AS
    SELECT 
        `b`.`Fk_id_usuario` AS `ID`,
        `a`.`nombre_usuario` AS `Usuario`,
        `a`.`username_usuario` AS `nickName`,
        `b`.`Fk_id_perfil` AS `perfil`,
        `c`.`nombre_perfil` AS `Nombre`
    FROM
        ((`Seguridad`.`Tbl_asignaciones_perfils_usuario` `b`
        JOIN `Seguridad`.`Tbl_usuarios` `a` ON ((`a`.`Pk_id_usuario` = `b`.`Fk_id_usuario`)))
        JOIN `Seguridad`.`Tbl_perfiles` `c` ON ((`c`.`Pk_id_perfil` = `b`.`Fk_id_perfil`)));
        
        
-- Procedimiento creado por Fernando García 0901-21-581--------------------------------------------------------
DELIMITER //

CREATE PROCEDURE procedimientoLogin(
    IN p_usuario VARCHAR(20),
    IN p_clave VARCHAR(100)
)
BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario AND password_usuario = p_clave;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN
        UPDATE tbl_usuarios
        SET ultima_conexion_usuario = NOW()
        WHERE username_usuario = p_usuario AND password_usuario = p_clave;
        
        SELECT 'Inicio de sesión exitoso' AS resultado;
    ELSE
        SELECT 'Inicio de sesión fallido' AS resultado;
    END IF;
END //

DELIMITER ;



-- Cambio de contraseña procedimiento ----------------------------------------------------------------------
DELIMITER //

CREATE PROCEDURE cambioContrasenia(
    IN p_usuario VARCHAR(20)
)
BEGIN
    DECLARE usuario_existe INT;

    SELECT COUNT(*) INTO usuario_existe
    FROM tbl_usuarios
    WHERE username_usuario = p_usuario;

    -- Si el usuario existe, actualiza el tiempo de última conexión
    IF usuario_existe > 0 THEN        
        SELECT 'Usuario encontrado' AS resu;
    ELSE
        SELECT 'Usuario no encontrado' AS resu;
    END IF;
END //

DELIMITER ;

-- Cambiar contraseña -----------------------------------------------------------------------------------------

DELIMITER //

CREATE PROCEDURE cambiarContrasenia(
    IN usuario VARCHAR(255),
    IN nuevaContrasenia VARCHAR(255),
    IN respuestaSeguridad VARCHAR(255)
)
BEGIN
    DECLARE respuestaGuardada VARCHAR(255);
    DECLARE usuarioExiste INT;

    -- Verificar si el usuario existe
    SELECT COUNT(*) INTO usuarioExiste 
    FROM tbl_usuarios 
    WHERE username_usuario = usuario;

    IF usuarioExiste = 0 THEN
        -- Si el usuario no existe, devolver mensaje de error
        SELECT 'Usuario no encontrado' AS resultado;
    ELSE
        -- Obtener la respuesta de seguridad desde la base de datos
        SELECT respuesta INTO respuestaGuardada 
        FROM tbl_usuarios 
        WHERE username_usuario = usuario;

        -- Verificar si la respuesta ingresada coincide con la guardada
        IF LOWER(respuestaGuardada) = LOWER(respuestaSeguridad) THEN
            -- Actualizar la contraseña
            UPDATE tbl_usuarios
            SET password_usuario = nuevaContrasenia
            WHERE username_usuario = usuario;
            
            -- Devolver el resultado exitoso
            SELECT 'Contraseña actualizada con éxito' AS resultado;
        ELSE
            -- Devolver resultado si la respuesta de seguridad es incorrecta
            SELECT 'Respuesta de seguridad incorrecta' AS resultado;
        END IF;
    END IF;
END //

DELIMITER ;



-- Cambiar contraseña desde el módulo ------------------------------------------------------------------------------
DELIMITER //

CREATE PROCEDURE cambiarContraModulo(
    IN p_usuario INT,
    IN p_nueva_contrasenia VARCHAR(100)
)
BEGIN
    -- Actualizar la contraseña del usuario
    UPDATE tbl_usuarios
    SET password_usuario = p_nueva_contrasenia
    WHERE pk_id_usuario = p_usuario;

    -- Confirmar que el cambio se realizó
    IF ROW_COUNT() > 0 THEN
        SELECT 'Contraseña actualizada con éxito' AS resultado;
    ELSE
        SELECT 'Usuario no encontrado' AS resultado;
    END IF;
END //

DELIMITER ;

-- Modificaciones ---------------------------------------------------------------------------------------------
ALTER TABLE tbl_bitacora_de_eventos RENAME TO tbl_bitacora;
SHOW CREATE TABLE tbl_bitacora;


-- Fernando García - 0901-21-581 - 60%
ALTER TABLE `Tbl_bitacora`
ADD COLUMN `tabla` VARCHAR(50) NOT NULL;


-- -----USUARIOS
-- Agrega el primer usuario
INSERT INTO `Tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '2022-07-02 21:00:48', '1', 'COLOR FAVORITO', 'ROJO');



-- Vamos a hashear admin para que puedea ingresar al programa
-- Deshabilitar el modo seguro en
-- edit->preferences->SQL Editor -> al final deshabilitar safe updates -> reconectar

-- Debe salir de la conexion y reconectar, volver a seleccionar y correr

UPDATE tbl_usuarios
SET password_usuario = SHA2('HO0aGo4nM94=', 256)
WHERE username_usuario = 'admin';


select * from tbl_usuarios;

