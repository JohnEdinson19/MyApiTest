-- Crear el esquema
CREATE SCHEMA testapi;

-- Crear la tabla Pais
CREATE TABLE testapi.Pais (
  PaisID SERIAL PRIMARY KEY,
  NombrePais VARCHAR(255) NOT NULL
);

-- Crear la tabla Departamento
CREATE TABLE testapi.Departamento (
  DepartamentoID SERIAL PRIMARY KEY,
  NombreDepartamento VARCHAR(255) NOT NULL
);

-- Crear la tabla Municipio
CREATE TABLE testapi.Municipio (
  MunicipioID SERIAL PRIMARY KEY,
  NombreMunicipio VARCHAR(255) NOT NULL
);

-- Crear la tabla Usuario
CREATE TABLE testapi.Usuario (
  UsuarioID SERIAL PRIMARY KEY,
  Nombre VARCHAR(50) NOT NULL,
  Telefono CHAR(15) NOT NULL,
  IdPais INT,
  IdDepartamento INT,
  IdMunicipio INT,
  Direccion VARCHAR(100),
  CONSTRAINT fk_Usuario_Pais FOREIGN KEY (IdPais) REFERENCES testapi.Pais(PaisID),
  CONSTRAINT fk_Usuario_Departamento FOREIGN KEY (IdDepartamento) REFERENCES testapi.Departamento(DepartamentoID),
  CONSTRAINT fk_Usuario_Municipio FOREIGN KEY (IdMunicipio) REFERENCES testapi.Municipio(MunicipioID)
);


-- Agregar índices
CREATE INDEX idx_Usuario_Nombre ON testapi.Usuario (Nombre);
CREATE INDEX idx_Usuario_PaisID ON testapi.Usuario (IdPais);
CREATE INDEX idx_Usuario_DepartamentoID ON testapi.Usuario (IdDepartamento);
CREATE INDEX idx_Usuario_MunicipioID ON testapi.Usuario (IdMunicipio);