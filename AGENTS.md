# AGENTS.md

## Fluxo obrigatório

1. Crie uma Issue para toda correção, melhoria, documentação ou nova funcionalidade.
2. Crie uma branch específica a partir de main.
3. Nunca altere main diretamente.
4. Abra um Pull Request e mencione a Issue com Closes #numero ou Refs #numero.
5. Execute dotnet format, dotnet build e dotnet test antes do merge.
6. Atualize o README quando o comportamento ou a estrutura mudarem.

## Qualidade

- Preserve encapsulamento, nomes claros e responsabilidades pequenas.
- Adicione testes unitários para toda regra de negócio alterada.
- Trate entradas inválidas sem encerrar inesperadamente o programa.
- Não adicione dependências sem necessidade.
- Em uma futura versão web, adicione logs estruturados e observabilidade apropriada.

## Interfaces

O projeto atual usa somente console. Caso receba uma interface web, siga Motion Principles: skeletons, lazy loading, estados de progresso, animações suaves e suporte a prefers-reduced-motion. Use Playwright para testes end-to-end da interface.
