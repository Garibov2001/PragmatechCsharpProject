<h1> Sales Management Application 
<h4> İşə salmaq üçün bələdçi

* Ilk olaraq reponu kompüterdə hər hansı bir folderə klonlayırıq (https://github.com/Garibov2001/PragmatechCsharpProject)
* Branchlardan "winform_final_project" - ə checkout edirik
* Entityləri yaratmaq üçün, "Tools -> NuGet Package Manager -> Package Manager Console " - da 
```update-database```
Qeyd : Default olaraq connection string server olaraq Visual Studionun localdbsini götürüb əgər başqa serverə qoşmaq istəsəniz App.Config - dən dəyişə bilərsiniz
* Bundan sonra bəzi default datalar var ki, onları bazaya yerləşdirmə lazımdır məsələn : Rolelar, admin accountu. Bunun üçün yaranmış yeni dbdə aşağıdakı queryni execute edirik:
```
USE SalesManagement

INSERT INTO Roles(Name) VALUES ('Admin');
INSERT INTO Roles(Name) VALUES ('Customer');

INSERT INTO Users(Name, Surname, Email, PhoneNumber, Password, Balance) 
VALUES ('Admin','Admin','admin@gmail.com',0000,'admin',000);

INSERT INTO UserRoles(UserID, RoleID) VALUES (1,1);
```
* Admin panelə daxil olmaq üçün registrasiyadan keçməyə ehtiyyac yoxdur. Əgər yuxarıda göstərilən queryni execute eləmisinizsə :
Email : admin@gmail.com
Password : admin


Db Design : https://app.dbdesigner.net/designer/schema/389708
