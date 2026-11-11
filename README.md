# VidaPet — TP1

Simulador de horários de consulta em C#, desenvolvido para o Projeto de Bloco.

## Estrutura

```text
VidaPet.TP1/
├── VidaPet.TP1.slnx
├── README.md
├── src/
│   ├── VidaPet.TP1.csproj
│   └── Program.cs
└── docs/
    ├── Felipe_Meira_PB_TP1.pdf
    └── videoTP1.mkv
```

As pastas `src/bin/` e `src/obj/` são geradas pelo .NET durante a compilação e
estão no `.gitignore`.

## Como executar

É necessário ter o SDK do .NET 10 instalado. Na raiz do repositório:

```bash
dotnet build
dotnet run --project src/VidaPet.TP1.csproj
```

O programa solicita o dia da semana, a hora e o minuto do início da consulta.
São permitidas consultas de 30 minutos, de segunda a sexta-feira, entre 08h00
e 18h00; o último início permitido é às 17h30.

## Documentação

- [Documento do TP1](docs/Felipe_Meira_PB_TP1.pdf)
- [Vídeo de apresentação](docs/videoTP1.mkv)
