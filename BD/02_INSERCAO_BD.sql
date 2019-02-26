--DEFINE O BANCO DE DADOS QUE SERÁ UTILIZADO
USE INLOCK_GAMES_MANHA;

--INSERE OS USUÁRIOS ADMINISTRADOR E CLIENTE NA TABELA USUARIOS
INSERT INTO USUARIOS(EMAIL, SENHA, TIPOUSUARIO)
VALUES				('admin@admin.com', 'admin', 'ADMINISTRADOR')
					,('cliente@cliente.com', 'cliente', 'CLIENTE');

--INSERE OS ESTUDIOS BLIZZARD, ROCKSTAR E SQUARE ENIX NA TABELA ESTUDIOS
INSERT INTO ESTUDIOS(NOMEESTUDIO)
VALUES				('Blizzard')
					,('Rockstar Studios')
					,('Square Enix');

--INSERE OS JOGOS DIABLO 3 E RDRII NA TABELA JOGOS
INSERT INTO JOGOS(NOMEJOGO, DESCRICAO, DATALANCAMENTO, VALOR, ESTUDIOID)
VALUES			 ('Diablo 3'
				 ,'é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã'
				 ,'2012-05-15'
				 ,99.00
				 ,1),
				 ('Red Dead Redemption II'
				 ,'jogo eletrônico de ação-aventura western'
				 ,'2018-10-26'
				 ,120
				 ,2);