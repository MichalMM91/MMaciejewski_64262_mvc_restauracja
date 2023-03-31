# Dokumentacja projektu - MMaciejewski_64262_mvc_restauracja_30012023

<h2>O projekcie</h1>

>Projekt wykonany w frameworku ASP.NET 6.0 przy zastosowaniu technologii MVC

<h2>Skąd wybór tej technogogii?</h2>

>Technologia MCV (Model-View-Controller) pozwala na logiczne rozdzielenie modelu, widoków i kontrolerów. Dało mi to elastyczność w dodawaniu kolejnych komponentów. Ich współpraca wydaje się przemyślana i pozwoliła w szybki sposób uzupełnić projekt o panel administracyjny menu, szerzej opisany w części technicznej projektu. Dodatkowo, rozszerzenie projektu o funkcjonalność filtrowania menu per Dieta nie sprawiło problemu technicznego i zostało łatwo zrealizowane za pośrednictwem dodania modelu ModelWyboruDiety i rozszerzenia widoku Dania o interpretację zmiennej searchString.

<h2>Specyfikacja biznesowa</h2>

>Projekt przedstawia stronę internetową wyimaginowanej restauracji yum-yum w Gdańsku. Podczas tworzenia treści inspirowałem się materiałami dostępnymi na istniejących witrynach, które wymieniłem w zakładce "Webmaster" strony.

<h3>Korzystanie z aplikacji z perspektywy klienta restauracji</h3>

<ol>
<li><b>Zakładka "O nas"</b> - Użytkownik będący klientem restauracji uruchamiając stronę główną zostaje przeniesiony do ekranu powitalnego - zakładki "O nas"</li>
<br>

![image](https://user-images.githubusercontent.com/48070450/215592995-3ab6ad30-2ef6-4324-84e1-5081135e750c.png)

<br>
<li><b>Zakładka "Menu"</b> - Po uruchomieniu zakładki "Menu" otwarta zostaje tabela z Menu restauracji. Dostępne funkcjonalnosći:
  <ul>
  <li>filtrowanie po nazwie dania</li>
  <li>wyświetlenie dań wyfiltrowanych per dieta (zbiór dostępnych diet to unikatowe wpisy w polu Dieta - wg. inicjalnej migracji zasilającej są to: "Vege", "Nie-vege" (oraz dodatkowa pozycja "Wszystkie"))</li>
  <li>wyświetlenie szczegółów każdego z dań</li>
  </ul>
  </ul>
 <br>
 
 ![image](https://user-images.githubusercontent.com/48070450/215593448-4f91a563-6648-4228-a370-92601d186576.png)
 
 <br>
 
 ![image](https://user-images.githubusercontent.com/48070450/215600981-5e731dee-0aef-4758-a99d-4ff4dfce5683.png)

 
 <br>
 <br>
 
 <li><b>Zakładka "Galeria"</b> - Po uruchomieniu zakładki "Galeria" użytkownik może przeglądać zdjęcia restauracji wewnątrz i na zewnątrz</li>
 <br>
 
 ![image](https://user-images.githubusercontent.com/48070450/215593536-ec8ad048-0ddd-4d97-b073-f1009be959e0.png)

<br>
 <li><b>Zakładka "Kontakt"</b> -Po uruchomieniu zakładki "Kontakt" użytkownik może poznać lokalizację restauracji, dane teleadresowe, informacje o menedżerze i informacje w jakich sprawach kontaktować się z menedżerem. Dodatkowo, jest możliwość uruchomienia stron restauracji na znanych serwisach społecznościowych (Restauracja nie istnieje, toteż przekierowanie jest ustawione każdorazowo na stronę główną serwisu społecznościowego)</li>
<br>

![image](https://user-images.githubusercontent.com/48070450/215593664-6467050e-c42d-4ff7-93d5-8edbbb23dc23.png)

<br>
<li><b>Zakładka "Webmaster"</b> -Po uruchomieniu zakładki "Webmaster" użytkownik może poznać dane twórcy projektu i inspiracje. Uwaga: w stopce strony znajduje się hiperłącze do tej zakładki</li>
<br>

![image](https://user-images.githubusercontent.com/48070450/215593817-91b51cb6-0937-48fd-b926-cb9bf2e882b3.png)

<br>
</ol>

<h3>Korzystanie z aplikacji z perspektywy menedżera restauracji / administratora</h3>

>Oprócz funkcjonalności opisanych w powyższym rozdziale "Korzystanie ze strony z perspektywy klienta restauracji" (dostępnych dla użytkownika - Klienta restauracji), Administrator / Menedżer restauracji posiada specjalny, tzw. "ukryty" widok. Ukryty - bo niedostępny jako przycisk zakładki w pasku nawigacyjnym, dostęny jedynie jeśli zna się prawidłowy adres URL. Na tym etapie projektu pominięto kwestie security i logowanie. 

>Dedykowany widok administracyjny dostępny jest po dopisaniu do adresu strony startowej frazy <b><i>/Admin</i></b>. Przykład:<br>
<i>https://localhost:7110/Admin</i>
<br>

![image](https://user-images.githubusercontent.com/48070450/215592003-333947b6-3834-489e-a2c2-1b2e605ad398.png)

<br>
W ramach Panelu administracyjnego, administrator/menedżer ma możliwość:
<ul>
<li>Dodawania nowego wpisu</li>
<li>Usuwania istniejącego wpisu</li>
<li>Edycji istniejącego wpisu</li>
<li>Wyświetlenia szczegółów istniejącego wpisu</li>
<li>Podstawowego filtrowania po nazwie dania (pominięto zaawansowane funkcjonalność filtrowania po dietach - jako nadmiarową dla administratora Menu)</li>
</ul>


![image](https://user-images.githubusercontent.com/48070450/215593986-6d8b6d55-e1e4-4c0c-a044-9a41a18377e9.png)


<h2>Dokumentacja techniczna</h2>

<h4>Język aplikacji</h4>

Aplikacja jest dostępna w jęz. polskim. Nazwy elementów strony zostały odpowiednio przetłumaczone.

<h4>Obrazki</h4>

Dostępne w lokalizacji <i>/wwwroot/img</i>

<h4>Modele</h4>

<ul>
<li>Danie - deklaracja zmiennych dań wchodzących w skład menu, wraz z customowymi nazwami kolumn</li>
<li>ErrorViewModel - domyślny</li>
<li>ModelWyboruDiety - model pozwalający na filtrowanie listy menu per Dieta</li>
<li>ZasilenieDanymi - tu zdefiniowałem inicjalną migrację zasilającą danymi po skompilowaniu, w sytuacji gdy wszystkie pozycje z Menu zostaną usunięte</li>
</ul>

<h4>Widoki</h4>

<ul>
<li>Folder Admin - składa się z widoków odpowiadających za panel administracyjny (index) oraz poszczególne widoki dodawania, edycji, usunięcia i szczegółów wpisu </li>
<li>Folder Dania - składa się z widoków odpowiadających za panel menu (index) oraz widok szczegółów wpisu </li>
<li>Folder Home - składa się z widoków odpowiadających za następujące zakładki menu: O nas (index), Galeria, Kontakt i Webmaster.</li>
<li>Folder Shared - m.in. sterowanie podstawowym layoutem strony w widoku _Layout</li>
</ul>

<h4>Kontrolery</h4>

<ul>
<li>AdminController - Kontroler dla widoku Admin</li>
<li>DaniaController - Kontroler dla widoku Dania wraz z mechaniką filtrowania per Dieta</li>
<li>HomeController - Kontroler dla widoków folderu Home</li>
</ul>


<h4>Migrations</h4>

Zawiera listę dotychczasowych migracji

<h4>Znane problemy</h4>

UWAGA na znany problem środowiska VisualStudio:

Rozwiązanie należy zapisać w jak najkrótszej ścieżce, najlepiej bezpośrednio na dysku - np. C:/... albo F:/... 

Jeżeli ścieżka do projektu będzie zbyt długa, a rozwiązanie będzie kompilowane z poziomu VisualStudio, to może wystąpić błąd kompilacji https://learn.microsoft.com/pl-pl/visualstudio/msbuild/errors/msb4018 

![image](https://user-images.githubusercontent.com/48070450/215851350-0d85851f-4ada-4302-9fbe-ad1caa6a42ac.png)

"Nastąpiło nieoczekiwane niepowodzenie zadania "GenerateStaticWebAssetsPropsFile" ". 

<b>Możliwości obejścia problemu:</b>
<ol>
<li>Zapisać projekt w krótkiej ścieżce, np. bezpośrednio na dysku, np. C:/ albo F:/</li>
<li>Ewentualnie zmienić nazwę projektu w Visual Studio na krótszą, np. MVC_MM<br />

![image](https://user-images.githubusercontent.com/48070450/215850337-42f67452-897a-4433-8072-e56d014661dc.png)

</li>
</ol>

Następnie rekompilować - błędy kompilacji nie powinny wówczas wystąpić.
<br />

<b>Możliwość sprawdzenia poprawności projektu:</b>
<ol>
<li>W lokalizacji root projektu zaznaczyć ścieżkę<br />

![image](https://user-images.githubusercontent.com/48070450/215850433-f526a8b1-53ba-4ac6-bae9-a84f20d24c02.png)

</li>
<li>wpisać cmd i wybrać ENTER<br />

![image](https://user-images.githubusercontent.com/48070450/215850819-a6f7dd70-3017-41aa-a76f-f17ef87a7b74.png)
  
</li>
<li>w otwartym oknie CommandLine'a wpisać komendę <i>dotnet build</i></li>
<li>otrzymujemy komunikat o sukcesie kompilacji - 0 błędów<br />
                              
![image](https://user-images.githubusercontent.com/48070450/215850676-78f63f3e-5400-4a66-8fde-470be35a6da8.png)

</li>
</ol>

Powyższe dowodzi problemu z IDE Visual Studio błędnie interpretującego długie ścieżki do katalogu źródłowego projektu.

