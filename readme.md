# Lern-Periode 3

Vincent Kistler

12.1. bis 23.2.2024

## Grob-Planung

1. Mit den Noten im Fach Informatik stehe ich eigentlich gar nicht schlecht dar, meine einzige Schwachstelle war das Modul 162 über Datenmodelieren, da dies aber ein wichtiger Baustein für das Modul 164 ist, werde ich mich damit nochmal auseinandersetzten.
2. ich hatte mir eigentlich vorgenommen mehrere Programme zu programmieren, da aber diese Lernperiode aus nur 4 Wochen besteht ist dies nahe zu unmöglich.
3. ich habe mir schon in Lernperiode 2 ein geignetes Projekt ausgesucht, und zwar ein Runner spiel wie flappy bird oder mario.

## 12.1.2024

heute habe ich an meinem Runner game weitergearbeitet. Man kann sich nun mit den Tasten d und a nach links und rechts bewegen. auch kann man mit der Spacebar springen und der charakter wird als 0 Dargestellt. Auch gibt es eine Platform auf die der Charakter gerumspringen kann. Was leider noch nicht funktioniert hat, sind die Obstacales also die Gegenstände in die der Charakter laufen kann und dann sterben soll.

## 19.1.2024

- [ ] Es sollen Hindernisse ins Spiel implementiert werden
- [ ] Das Movment soll entfernt werden und das Programm soll automatisch für den Spieler laufen.
- [ ] Das Programm soll weiterlaufen, also wie bei flappy bird (kein ende)
- [ ] Die Gegenstände sollen zufällig generiert werden. (höhe und breite)
      

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 1               |  Spieler soll sterben wenn er ein hinderniss berührt.                    |  Programm soll checken ob er eine Kollision mit einem Hinderniss gibt              |    Spiel soll sich beenden            | nein         |
| 2           |    Der Spieler soll sich nicht selber bewegen können, sondern das Programm soll vonalleine Pro 100 ticks ein tile nach vorne gehen                  |       programm lässt einen zähler hochzählen und jedes mal geht er ein tile nach vorne         |   Soll aufhören wenn eine Kollision entdeckt wurde             |  nein        |
| 3             |   programm soll das Spielfeld immer wieder neu zeichnen                   |   es läuft auch ein zähler im hintergrund der jedes mal das Spielfeld um 1 erweitert und das hinten um 1 kürtzt             |  das Spielfeld soll niemald enden              |   nein       |
| 4               | jedes Hinderniss soll zufällig generiert werden| zwei Zahlengeneratoren wählen eine Zahl aus diese bestimmen die höhe sowie breite des hindernisse| Die Hindernisse werden im Anschluss aufs Spielfeld gezeichnet| nein|

✍️ Heute am 16.1 habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 26.1.2024

- [ ] Es soll ein Score Board am Rande hochzählen jedes mal wenn ein Hinderniss erfüllt wird
- [ ] Der Spieler soll auswählen können ob er nochmal spielen möchte oder nicht
- [ ] Das Programm sollte in ein GUI umgewandelt werden
- [ ] Das Programm sollte ein End screen haben

- [ ] Achtes AP

| Testfall-Nummer | Ausgangslage (Given)                                         | Eingabe (When)              | Ausgabe (Then) | Erfüllt? |
| --------------- | ------------------------------------------------------------ | --------------------------- | -------------- | -------- |
| 5               |   Es soll ein Score Board am Rande hochzählen jedes mal wenn ein Hinderniss erfüllt wird  | das Programm checkt ob das Hinderniss erfolgreich gemeistert wurde                            |wenn ja zählt das scoreboard 1 nach hoch wenn nicht beendet sich das Spiel                |  nein        |
| 6              | Der Spieler soll auswählen können ob er nochmal spielen möchte oder nicht | ja oder nein | bei ja beginnt es nochmal bei nein beendet es sich    | nein         |
| 7            |     Das Programm sollte in ein GUI umgewandelt werden |     -                        |     -           |     -     |
| 8| Das Programm sollte ein End screen haben| Programm checkt ob der spieler gestorben ist| Das programm zeigt ein Death screen an und frägt ob man nochmal spielen möchte|nein|
✍️ Heute am 23.1 habe ich... (50-100 Wörter)

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt

## 16.2.2024

✍️ Heute am 23.1 habe ich... (50-100 Wörter)

## Reflexion

Formen Sie Ihre Zusammenfassungen in Hinblick auf Ihren VBV zu einem zusammenhängenden Text von 100 bis 200 Wörtern (wieder mit Angabe in Klammern).

Verfassen Sie zusätzlich einen kurzen Abschnitt, in welchem Sie über die Länge der Projekte reflektieren: Fanden Sie die 10-wöchtige LP2 oder die 4-wöchige LP3 angenehmer? Was bedeutet das für Ihre Planung der zukünftigen LP?
