# Discord-Status
## これは何？
Discordのstatusをカスタマイズするソフトです<br>
![image](https://user-images.githubusercontent.com/83022348/206895773-1c721900-5d6f-496b-8f46-9b2d9db7e14e.png)
## HOW TO USE
### 1.アプリケーション作成
まず初めにDiscord Developer Portal へアクセスし表示用のアプリケーションを作成します。<br>
[https://discord.com/developers/applications](https://discord.com/developers/applications)<br>
ログインしたら`New Application`をクリックしアプリケーションを作成します。<br>

### 2. アプリケーション設定
#### 1. 名前の設定
次に`General Information`タブを設定します。<br>
<br>
特に`NAME`で設定する名前は下の画像で赤で囲んだ部分になるので表示させたい名前に設定してください。<br>
![image](https://user-images.githubusercontent.com/83022348/206896084-c5f876e3-0b7e-46e0-9882-a0291503c933.png)<br>
`DESCRIPTION`や`TAGS`は各自で設定してください(しなくてもOK)<br>
#### 2. 画像の設定
次に`Rich Presence`タブの`Rich Presence Art Assets`を設定します。<br>
*※現在の Ver 1.0 では `Rich Presence Invite Image`の`COVER IMAGE`は使用できませんので設定する必要はありません。*<br>
<br>
ここで設定する画像は下の画像の赤で囲んだ部分になるので表示させたい画像を設定してください。<br>
![image](https://user-images.githubusercontent.com/83022348/206896408-8a6f9470-5cfc-46f0-bbd4-689b7e95a614.png)<br>
`Rich Presence Assets`の`Add Image(s)`をクリックし画像を選択してください。<br>
(同時に選択することも可能です。最大300個まで保存できます。)<br>
<br>
なお`Key`は新規に画像を登録するときのみ設定可能です。(画像を一度消してもう一度登録すれば変更できます。)<br>
![image](https://user-images.githubusercontent.com/83022348/206896549-e2ce8a5f-d256-4a61-8929-8d9e55308b75.png)

### 3. ソフトウェアの設定
#### 1. Discordへログイン
ここまで設定ができたらリリースからダウンロードしたソフトを起動してください。<br>
**※不明な発行元と出る場合がありますが問題ありませんので実行してください。**

起動したら`Application ID`に先ほど設定した`General Information`タブにある`APPLICATION ID`を入力してください。<br>
入力ができましたら右にある**ログイン**ボタンをクリックしてください。<br>
エラーなどが特にでなければDiscordへログイン成功です。

#### 2. 各種項目の設定
##### パーティー
パーティーは下の画像の赤で囲んだ部分です。<br>
![image](https://user-images.githubusercontent.com/83022348/206896897-efff66f1-7d50-42a3-b639-2c3e1e9389ad.png)<br>
左が`Size`で右が`Max`です。<br>
`Size`を`Max`より大きく設定することはできません。
##### ラージイメージ
ラージイメージは下の画像の赤で囲んだ部分です。<br>
![image](https://user-images.githubusercontent.com/83022348/206896939-b5c59752-656b-4b55-ac43-7f78c6441354.png)<br>
`Key`は先ほど画像を登録したときに設定した`Key`を入力してください。<br>
`Text`はマウスカーソルを画像に当てているときに出てくる文字です。<br>
![image](https://user-images.githubusercontent.com/83022348/206897065-e07bb8dc-2e8f-4c2b-99e9-1f4869e6bca5.png)
##### スモールイメージ
スモールイメージは下の画像の赤で囲んだ部分です。<br>
![image](https://user-images.githubusercontent.com/83022348/206897088-b2ee35b0-f548-4cf5-8cf4-a2ee4fc49f2f.png)<br>
主な設定はラージイメージと同じです。
##### タイムスタンプ
タイムスタンプは`Start`(`経過`)か`End`(`残り`)を設定できます。<br>
![image](https://user-images.githubusercontent.com/83022348/206897206-f5662b10-5c3e-4a1a-8e97-7390a3d01bf0.png)![image](https://user-images.githubusercontent.com/83022348/206897215-c39652df-7d2a-4c04-a260-eebc5655f384.png)<br>
それぞれ設定した時間から、設定した時間までという計算になっています。<br>
##### ボタン
ボタンは最大2個まで追加することが可能です。<br>
![image](https://user-images.githubusercontent.com/83022348/206897280-0cb2386b-5133-47c5-b3c4-3e7742ac0bbd.png)<br>
`Label`はボタンの名前、`URL`はクリックしたときに飛ぶリンクを設定できます。

### 4. データの保存、共有について
本ソフトウェアではユーザー間で設定を簡単に共有できるように、設定のエクスポート機能とインポート機能を搭載しています。<br>
window上部のメニューの`ファイル`よりエクスポートとインポートを行えます。<br>
<br>
設定したデータは上記と同じメニュー上にある`保存`より本ソフトウェアを実行しているディレクトリに保存されます。<br>
次回起動時に自動で読み込まれます。

### 5. エラー発生時について
極力エラー対策をしているつもりでも予期せぬエラーが発生する可能性があります。<br>
エラー発生時はwindow最下部にある`Console Log`をコピーし私に送信してください。


なお本ソフトウェアを自分で作ったと自称する行為や無断での商用利用は一切禁止です。

追加してほしい機能等がある場合は下記のURL上のSNSよりお願いします。
[https://kuwa.dev/](https://kuwa.dev/)
