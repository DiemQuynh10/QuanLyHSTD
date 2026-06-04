# Team Git Workflow Guide

This document describes the Git workflow used during the development of the CyberFortis Recruitment Management System project.

## Repository Structure

The project follows a simple branching strategy:

| Branch    | Purpose                             |
| --------- | ----------------------------------- |
| main      | Stable production-ready source code |
| dev       | Integration branch for development  |
| feature/* | Individual feature development      |

---

## Getting Started

Clone the repository:

```bash
git clone https://github.com/DiemQuynh10/QuanLyHSTD.git
cd QuanLyHSTD
```

---

## Sync Latest Changes

Before starting any task, update the latest code from the development branch:

```bash
git checkout dev
git pull origin dev
```

Then switch to your working branch:

```bash
git checkout feature/your-branch
git merge dev
```

---

## Commit Changes

After completing a task:

```bash
git add .
git commit -m "Describe completed work"
```

Examples:

```bash
git commit -m "Add candidate filtering"
git commit -m "Update interview dashboard"
git commit -m "Fix login validation"
```

---

## Push Changes

Push your branch to GitHub:

```bash
git push origin feature/your-branch
```

---

## Pull Request Process

1. Create a Pull Request.
2. Set:

   * Base branch: `dev`
   * Compare branch: your feature branch.
3. Submit the Pull Request for review.
4. Merge only after approval.

---

## Development Rules

* Do not commit directly to `main`.
* Pull the latest changes before starting work.
* Keep commits small and meaningful.
* Use clear commit messages.
* Test changes before creating a Pull Request.

---

## Recommended Workflow

```bash
git checkout dev
git pull origin dev

git checkout feature/your-branch
git merge dev

# Development

git add .
git commit -m "Describe completed work"
git push origin feature/your-branch
```

---

CyberFortis Recruitment Management Team
