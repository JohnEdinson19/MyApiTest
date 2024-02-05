CREATE OR REPLACE PROCEDURE testapi.insertar_usuario(
    IN p_nombre character varying,
    IN p_telefono character,
    IN p_id_pais integer,
    IN p_id_departamento integer,
    IN p_id_municipio integer,
    IN p_direccion character varying
)
LANGUAGE plpgsql
AS $procedure$
BEGIN
    INSERT INTO testapi.Usuario(
        Nombre,
        Telefono,
        IdPais,
        IdDepartamento,
        IdMunicipio,
        Direccion
    ) VALUES (
        p_nombre,
        p_telefono,
        p_id_pais,
        p_id_departamento,
        p_id_municipio,
        p_direccion
    );
END;
$procedure$;