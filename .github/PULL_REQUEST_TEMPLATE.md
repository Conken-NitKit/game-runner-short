## 概要
<!-- 今回のPRの 実装内容 & 変更するに至った背景 を記載してください。 -->

## デバッグ項目
<!--
実装に不具合がないことを確認するために行った項目です。
- [ ] 入力例 1
- [ ] 入力例 2
-->

## スクリーンショット
<!--
実際にどのような表示かの写真を貼り付ける項目です。
動画の場合は下記の表を消して、[この記事](https://zenn.dev/naminodarie/articles/27f9c260fd81fd)を参考に動画を追加してください。
-->

| Before | After |
| :-: | :-: |
| <img width="450" alt="" src=""> | <img width="450" alt="" src=""> |

## 参考URL
<!--
参考にした記事があれば、そのURLを記載してください。
- 参考にしたURL 1
- 参考にしたURL 2
-->

## Self-Checking points 🚨

レビューを依頼する前に必ず確認してほしいポイントです。
一般的な項目を上げているので、プロジェクト毎に必要なポイントがあれば各リポジトリで追加してください。

### 共通 (命名)
- [ ] `data`, `info`, `value` などの汎用的で抽象度の高い変数名を使っていない → [参考](https://neos21.net/blog/2020/01/28-01.html) 
- [ ] 配列には末尾に `s` をつけて複数形にするか `xxxList` と命名することで配列であることを明確にしている → [参考](https://teratail.com/questions/161176)
- [ ] マジックナンバーは極力存在せず、定数を用いて表現されている → [参考](https://twitter.com/program_shiba/status/1483378634975072260)
- [ ] パッと見で何をやってるかわからないような処理の結果を **説明変数** している → [参考](https://wb-hp.com/blog/2020/11/09/explanatory-variable.html)
- [ ] 複雑な条件式の結果を **要約変数** を適用している → [参考](https://twitter.com/hakuto00/status/1362608154840760320)
- [ ] 関数は動詞始まりにして、何をする関数かを明確にしている → [参考](https://zenn.dev/ccccc/articles/5a60336f54f429)

### 共通 (処理系)
- [ ] **早期リターン（ガード節）** を適用することで条件分岐の簡略化している → [参考](https://zenn.dev/media_engine/articles/early_return)
- [ ] if文では「調査対象」を左側に、「比較対象」を右側に配置している → [参考](https://twitter.com/yuuuma_11/status/1347374986160340992/photo/2)
- [ ] 値のパターンによって分岐する場合は `if/else文` ではなく、`switch文` を使う → [参考](https://blog.senseshare.jp/if-switch.html)

### 共通 (コメント系)
- [ ] コメントには適切なアノテーションコメントが記載されている → [参考](https://qiita.com/taka-kawa/items/673716d77795c937d422)

### C# (命名)
- [ ] ローカル変数 には `キャメルケース` を利用する → [参考](https://qiita.com/TakeshiNishioka/items/501979ad126e9707758c)
- [ ] メソッド, クラス, 定数, Enum, 型変数, 例外, 名前空間, モジュール には `パスカルケース` を利用する → [参考](https://qiita.com/TakeshiNishioka/items/501979ad126e9707758c)

### C# (コメント系)
- [ ] クラス, メソッド には `ドキュメントコメント` を記載している → [参考](https://ekulabo.com/use-doc-comment)

### Unity (処理系)
- [ ] `Find` や `GetComponent` は極力使用せずに、`SerializeField` などを使うようにしている → [参考](https://northprint.net/?p=92)
- [ ] クラス内で完結する変数には `Public変数` ではなく `Private変数` を使っている → [参考](https://qiita.com/makopo/items/8ef280b00f1cc18aec91)
- [ ] アタッチするオブジェクトのクラスが明確な場合は `Prefabのシリアライズ` に `GameObject` を使わず,<br>アタッチするオブジェクトのクラスを明示的に指定している → [参考](https://r-ngtm.hatenablog.com/entry/2018/02/22/200320)
- [ ] ゲームロジックの実装はUpdateではなく、FixedUpdateで行っている → [参考](https://qiita.com/ogawa-to/items/c9988f45516c0d331354)

### 共通 (その他)
- [ ] フォーマット差分などは PR 上に一言 `インラインコメント` を付けて、レビュワーが省エネできるように → [参考](https://docs.github.com/ja/pull-requests/collaborating-with-pull-requests/reviewing-changes-in-pull-requests/commenting-on-a-pull-request)
