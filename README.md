# LabbCleanCode
Clean Code Laboration Elliot, Emil .NET21

Vi började projektet med att dela upp dom största metoderna och klasserna i egna foldrar och filer, på så sätt kan vi enkelt hitta och underhålla koden. Detta gjordes även genom git och pushades upp till ett github repository genom olika branches med kommentarer så att vi kan se vad som ändrades och enkelt kunde backa koden om något gått fel. Vi flyttade över all kod som låg i main till egna foldrar och filer. Vi satte även upp interfaces för de olika klasser och implementerade några grundläggande Unit tester. Vi valde att arbeta med interface för att sätta villkor för de klasser vi delade upp i programmet.

Arbetade även med dependency injection för att det i framtiden blir lättare att ha testbar kod, enklare att skapa unit tester samt att vissa klasser ska kunna komma åt varandras data och information. Vi la till IO integration samt interface och metoder så att programmet lätt kan hanteras av framtida frontend utvecklare.

Efter uppdelningen samt majoriteten av refaktoreringen gick vi igenom stora metoder och bröt ner dom till mindre läsbara funktioner. Vi ändrade oförklarbara variabelnamn och tog bort onödiga kommentarer. Vi la även till fler unit tester och jobbade med felhantering med try catch.

Programmet är refaktorerat och betydligt mer läsbar än innan. Vi jobbade mycket med att ej optimera koden så att funktionaliteten alltid var densamma.
