# CI/CD Reflection

## What is the purpose of CI/CD?
CI/CD automates the process of building, testing, and validating code changes before they are merged.  
In my case, it helped ensure that every Pull Request was checked automatically before approval, reducing manual review effort and preventing basic mistakes from reaching the main branch.

## How does automating style checks improve project quality?
I used **GitHub Actions** to run automated checks on each Pull Request.  
These checks verified code formatting and documentation consistency, which helped catch small issues early and kept the repository standards consistent without relying on manual review.

## What are some challenges with enforcing checks in CI/CD?
During setup, one challenge was understanding why a workflow failed when the configuration was incorrect.  
Another issue was that strict checks can block a PR for minor problems, which requires balancing enforcement with developer productivity.

## How do CI/CD pipelines differ between small projects and large teams?
In this project, the CI/CD pipeline was relatively simple and focused on basic validation using GitHub Actions.  
In larger teams, pipelines usually include multiple stages such as unit tests, UI tests, security scanning, and deployment approvals, making them more complex but also more reliable.

## Personal Experience
I configured a GitHub Actions workflow that ran automatically on Pull Requests.  
When I opened a test PR, the workflow executed and reported its status directly on GitHub, which helped me understand how CI/CD provides fast feedback and enforces quality gates before merging.

Evudence:
```yaml
name: CI Checks

on:
  pull_request:
    branches:
      - main
      - master
    paths:
      - '**/*.md'

jobs:
  markdown-checks:
    runs-on: ubuntu-latest

    steps:
      - name: Checkout repository
        uses: actions/checkout@v4

      - name: Set up Node.js
        uses: actions/setup-node@v4
        with:
          node-version: '20'

      - name: Install tools
        run: npm install -g markdownlint-cli cspell

      - name: Run markdownlint
        run: markdownlint "**/*.md"

      - name: Run cspell
        run: cspell "**/*.md" --no-progress

```

