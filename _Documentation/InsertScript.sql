INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FORM_TAGS_GROUP', 'FORM_TAGS', 'Grupa dla tagów formularzy', NULL);
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FORM_TAG_A', 'A', 'Tag formularza A', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FORM_TAGS_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FORM_TAG_B', 'B', 'Tag formularza B', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FORM_TAGS_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_TAGS_GROUP', 'FIELD_TAGS', 'Grupa dla tagów pól', NULL);
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_TAG_A', 'A', 'Tag pola A', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_TAGS_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_TAG_B', 'B', 'Tag pola B', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_TAGS_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_VALUE_TYPES_GROUP', 'FIELD_VALUE_TYPES', 'Grupa dla rodzajów wartości pól', NULL);
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_VALUE_TYPE_STRING', 'STRING', 'Napis', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_VALUE_TYPES_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_VALUE_TYPE_INTEGER', 'INTEGER', 'Liczba całkowita', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_VALUE_TYPES_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_VALUE_TYPE_DECIMAL', 'DECIMAL', 'Liczba dziesiętna', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_VALUE_TYPES_GROUP') AS x));
INSERT INTO Dictionary(AddLogin, Name, Value, Description, ParentId) VALUES('SYSTEM', 'FIELD_VALUE_TYPE_DATATIME', 'DATETIME', 'Data', (SELECT Id FROM (SELECT Id FROM Dictionary WHERE Name = 'FIELD_VALUE_TYPES_GROUP') AS x));

INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'TEXTFIELD', 'Pole tekstowe', 0);
INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'SELECT', 'Lista rozwijana', 0);
INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'MULTISELECT', 'Lista wielkrotnego wyboru', 0);
INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'NUMBER', 'Liczba', 1);
INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'DECIMAL', 'Liczba dziesiętna', 2);
INSERT INTO FieldType(AddLogin, Name, Title, DataType) VALUES('SYSTEM', 'DATETIME', 'Data', 3);

-- TEMP DATA FOR TESTS --

INSERT INTO FieldValidationRule(AddLogin, Name, Description, Pattern, Message, FieldTypeId) VALUES('TEMP', 'Raz', 'Dwa', 'Trzy', 'Cztery', (SELECT Id FROM FieldType WHERE Name = 'TEXTFIELD'));

INSERT INTO FormTemplate(AddLogin, Name, Title) VALUES('TEMP', 'FUEL_CONSUMPTION', 'Zużycie paliwa');

INSERT INTO FormField(AddLogin, Name, Title, TemplateId, FieldTypeId) VALUES('TEMP', CONCAT('DECIMAL-', DATE_FORMAT(NOW(), '%Y%m%d%H%i%s')), 'Kwota', (SELECT Id FROM FormTemplate WHERE Name = 'FUEL_CONSUMPTION'), (SELECT Id FROM FieldType WHERE Name = 'DECIMAL'));
INSERT INTO FormField(AddLogin, Name, Title, TemplateId, FieldTypeId) VALUES('TEMP', CONCAT('DATE-', DATE_FORMAT(NOW(), '%Y%m%d%H%i%s')), 'Data', (SELECT Id FROM FormTemplate WHERE Name = 'FUEL_CONSUMPTION'), (SELECT Id FROM FieldType WHERE Name = 'DATETIME'));

INSERT INTO Form(AddLogin, TemplateId) VALUES('TEMP', (SELECT Id FROM FormTemplate WHERE Name = 'FUEL_CONSUMPTION'));
INSERT INTO FormData(AddLogin, DecimalValue, FieldId, FormId) VALUES('TEMP', 57.32, (SELECT Id FROM FormField WHERE Title = 'Kwota'), (SELECT MAX(Id) FROM Form));
INSERT INTO FormData(AddLogin, DateTimeValue, FieldId, FormId) VALUES('TEMP', STR_TO_DATE("2020/12/08", "%Y/%m/%d"), (SELECT Id FROM FormField WHERE Title = 'Data'), (SELECT MAX(Id) FROM Form));

INSERT INTO Form(AddLogin, TemplateId) VALUES('TEMP', (SELECT Id FROM FormTemplate WHERE Name = 'FUEL_CONSUMPTION'));
INSERT INTO FormData(AddLogin, DecimalValue, FieldId, FormId) VALUES('TEMP', 49.54, (SELECT Id FROM FormField WHERE Title = 'Kwota'), (SELECT MAX(Id) FROM Form));
INSERT INTO FormData(AddLogin, DateTimeValue, FieldId, FormId) VALUES('TEMP', STR_TO_DATE("2020/12/05", "%Y/%m/%d"), (SELECT Id FROM FormField WHERE Title = 'Data'), (SELECT MAX(Id) FROM Form));