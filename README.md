# Welcome to the Swiss pairing library

This is a simple library for pairing players (on tournaments) following simple Swiss pairing algorithm.

Use case for this algorithm are Chess tournaments or any other tabletop (or non tabletop) games where number of players exceed number of games/rounds played.

## Algorithm implementations

This library contains two implementations: `SwissAlgorithm` and `SwissGenericAlgorithm`. Both implementations are using generic objects as player data representatives, but the first one demands that player data objects inherit from `ISwissPlayer` interface.

## Contents

Beside the library project itself, this solution contains a Demo project (Windows Forms) and xUnit tests.

Library project with Swiss algorithm implementations are made in .NET Standard 2.1 framework.
