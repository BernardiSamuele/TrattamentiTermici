# Progetto di Simulazione Macchinario per Trattamenti Termici

## Descrizione del Progetto

Questo progetto è stato sviluppato come parte di un'attività scolastica e utilizza Siemens TIA Portal per simulare il funzionamento di un macchinario per trattamenti termici. La simulazione riproduce il comportamento di un sistema automatizzato che esegue il seguente processo:

1. Il macchinario parte e preleva un pezzo da trattare.
2. Il pezzo viene trasportato in avanti e immerso in un liquido **sei volte**.
3. Successivamente, il pezzo viene spostato ulteriormente in avanti verso un secondo cilindro.
   - Durante l'avanzamento, il macchinario apre il coperchio del secondo cilindro.
4. Quando il pezzo raggiunge il secondo cilindro, viene nuovamente immerso in un liquido.
5. Infine, il pezzo ritorna alla posizione iniziale, dove viene scaricato.
6. Il ciclo riparte con il prelievo di un nuovo pezzo.

## Obiettivi del Progetto

- **Apprendimento pratico**: Approfondire l'uso di Siemens TIA Portal per la programmazione di PLC.
- **Simulazione realistica**: Riprodurre un ciclo completo di trattamento termico automatizzato.
- **Ottimizzazione del processo**: Implementare logiche efficienti per il controllo dei movimenti e delle operazioni.

## Strumenti Utilizzati

- **Siemens TIA Portal**: Per la programmazione e la simulazione del PLC.
- **PLC Siemens S7-1200**: Modello di riferimento per la programmazione.
- **HMI (opzionale)**: Per interfacciarsi con l'utente e monitorare il processo.

## Funzionamento del Sistema

### Fasi Principali
1. **Prelievo del pezzo**:
   - Il macchinario si posiziona sul pezzo e lo solleva per iniziare il ciclo.
2. **Immersione iniziale**:
   - Il pezzo viene spostato verso il primo liquido e immerso **sei volte**.
3. **Avanzamento al secondo cilindro**:
   - Il pezzo continua il movimento in avanti.
   - Il coperchio del secondo cilindro si apre in anticipo per accogliere il pezzo.
4. **Immersione nel secondo liquido**:
   - Quando il pezzo raggiunge il secondo cilindro, viene immerso nel liquido.
5. **Ritorno alla posizione iniziale**:
   - Il pezzo viene riportato alla posizione di partenza, scaricato, e il ciclo si ripete.

### Logiche Implementate
- **Controllo dei movimenti**: Gestione precisa degli assi per lo spostamento dei pezzi.
- **Sequenze di immersione**: Temporizzazioni configurabili per regolare la durata e il numero di immersioni.
- **Automazione del coperchio**: Sincronizzazione tra il movimento del pezzo e l'apertura/chiusura del coperchio.

## Configurazione

1. **Requisiti hardware**:
   - PLC Siemens S7-1200 o equivalente.
   - Componenti di ingresso/uscita digitali per sensori e attuatori.
2. **Requisiti software**:
   - Siemens TIA Portal versione XX o successiva.
3. **Setup del progetto**:
   - Importare il progetto TIA Portal fornito nella cartella `project`.
   - Configurare il PLC e le I/O in base al layout del macchinario.

## Istruzioni per l'Uso

1. Importare il file del progetto in Siemens TIA Portal.
2. Caricare il programma sul PLC.
3. (Opzionale) Configurare il pannello HMI per monitorare il processo.
4. Avviare la simulazione per osservare il comportamento del macchinario.

## Note

- La simulazione è stata realizzata per scopi didattici e non rappresenta un'applicazione industriale reale.
- Il numero di immersioni e i tempi di ciclo possono essere modificati nel programma per adattare la simulazione a diverse esigenze.

## Contatti

Per ulteriori informazioni, contattare il docente o il team di sviluppo del progetto.

## Crediti

Questo progetto è stato realizzato da **Delsoglio Leonardo** [@DelsoglioLeonardo](https://github.com/DelsoglioLeonardo) e **Bernardi Samuele** [@BernardiSamuele](https://github.com/BernardiSamuele)
