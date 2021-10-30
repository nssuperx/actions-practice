# actions-practice
[![Build project](https://github.com/nssuperx/actions-practice/actions/workflows/gameci-build.yml/badge.svg)](https://github.com/nssuperx/actions-practice/actions/workflows/gameci-build.yml)

github actionsの練習

## やったこと
1. pull request出してみて、それで走るか確認。（on: [push]を確認）
1. status badgeつけてみる
1. self host runner つかってみる。
1. gameCI つかってみる。
    1. ライセンスのアクティベーション
1. scp使って、OCIにたてたインスタンスからファイルをコピーしてくる(unitypackage)
1. unity cliを使ってunitypackageをインポート
1. ビルド
    1. ビルド実行スクリプトは`Assets/Editor`以下に配置
1. [github-pages-deploy-action](https://github.com/marketplace/actions/deploy-to-github-pages)を使ってgithub pagesにデプロイ

# 参考
[GitHub ActionsでUnityでunitypackage生成とビルド＆実機(Linux)ユニットテストを実行する - neuecc blog](http://neue.cc/2020/04/22_591.html)

## ドキュメント
* [GitHub Actionsのドキュメント](https://docs.github.com/ja/actions)
* [コンテキスト](https://docs.github.com/ja/actions/learn-github-actions/contexts)
    * `github.workspace`, `job.status` とか `${{ <context> }}` として使うもの
* [GitHub Actionsのワークフロー構文](https://docs.github.com/ja/actions/learn-github-actions/workflow-syntax-for-github-actions)
    * `on`, `jobs`, `env` とか
* [環境変数](https://docs.github.com/ja/actions/learn-github-actions/environment-variables)
