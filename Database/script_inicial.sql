USE MyFirstAPI;

/********************************************************
    Criação da tabela de pessoa
/********************************************************/

CREATE TABLE Pessoa (
    Codigo INT NOT NULL AUTO_INCREMENT,
    Nome VARCHAR(100) NOT NULL,
    Endereco VARCHAR(200) NOT NULL,
    PRIMARY KEY(Codigo)
);

/********************************************************
    Registros iniciais
/********************************************************/

INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 1', 'Endereço 1');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 2', 'Endereço 2');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 3', 'Endereço 3');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 4', 'Endereço 4');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 5', 'Endereço 5');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 6', 'Endereço 6');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 7', 'Endereço 7');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 8', 'Endereço 8');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 9', 'Endereço 9');
INSERT INTO Pessoa(Nome, Endereco) VALUES('Pessoa 10', 'Endereço 10');