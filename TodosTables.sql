DROP TABLE todos;

CREATE TABLE IF NOT EXISTS todos(
  id int AUTO_INCREMENT NOT NULL,
  userid VARCHAR(255),
  title VARCHAR(255),
  completed TINYINT,

  PRIMARY KEY (id)
);

INSERT INTO todos(userid, title, completed)
VALUES("test", "Todo 1", 1);
INSERT INTO todos(userid, title, completed)
VALUES("test", "Todo 2", 1);
INSERT INTO todos(userid, title, completed)
VALUES("test", "Todo 3", 1);
INSERT INTO todos(userid, title, completed)
VALUES("test", "Todo 4", 1);
INSERT INTO todos(userid, title, completed)
VALUES("test", "Todo 4", 0);