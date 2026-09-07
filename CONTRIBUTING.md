# Contribuindo para o projeto

## Commits

Cada commit deve representar uma alteração lógica e específica. Evite juntar várias alterações diferentes em um único commit.

## Código

* Indentação: 4 espaços
* Chaves: nova linha
* Classes: `PascalCase`
* Variáveis e parâmetros: `camelCase`
* Campos privados: `_camelCase`

## Comentários

Comentários importantes podem utilizar o nome do desenvolvedor:

```csharp
// [Nome] Explicação do funcionamento deste trecho.
```

Use comentários para explicar decisões, comportamentos ou partes do código que possam não ser óbvias.

## Git

* Sempre faça `Pull` antes de começar a trabalhar.
* Faça `Commit` depois de concluir uma alteração lógica.
* Faça `Push` após o commit para compartilhar suas alterações.
* Não faça commit da pasta `.godot/`.
* Evite trabalhar simultaneamente no mesmo arquivo quando possível.

## Prefixos de Commit

Usamos os seguintes prefixos para manter o histórico organizado:

* `feat:` — nova funcionalidade
* `fix:` — correção de bug
* `refactor:` — reorganização ou melhoria do código sem alterar seu comportamento
* `scene:` — criação ou alteração de cenas
* `asset:` — adição ou alteração de assets
* `docs:` — documentação e comentários
* `chore:` — configurações e manutenção do projeto

## Exemplos

```text
feat: adiciona sistema de combustível

fix: corrige cálculo do peso da nave

refactor: reorganiza código da nave

scene: cria cena principal

asset: adiciona textura do motor

docs: documenta sistema de física

chore: configura editorconfig
```