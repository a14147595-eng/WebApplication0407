# 使用者管理與產品系統（ASP.NET MVC）

## 專案簡介

本專案為使用 ASP.NET MVC 架構開發之簡易管理系統，實作使用者登入、註冊、權限控制與產品資料管理功能，重點在於理解系統流程與後端邏輯設計。

---
# 畫面截圖
 ##註冊
 進去後會看有無session資料 若無則跳到註冊頁面
 帳密用if 檢查不能為空
 使用者名稱
<img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/7fe49d02-9435-4460-ba18-c9b90673fadf" />
 ##登入畫面
 <img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/f0bc8479-09d1-40a6-b054-3bc8e7c92395" />
 ##首頁
 <img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/5dab861a-745c-4f99-bbc7-1964890f56e7" />
 ##查看筆記
<img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/bebed3b4-e109-4a97-96be-4ff546124133" />

##如果是admin登入
<img width="960" height="600" alt="image" src="https://github.com/user-attachments/assets/cd17a009-2d95-4d83-bb93-a94f1320d79a" />








# 功能介紹

### 使用者系統

* 使用者註冊（Register）
* 使用者登入 / 登出（Login / Logout）
* 使用 Session 管理登入狀態

### 權限控制（Role-Based）

* 使用者分為 `admin` 與 `user`
* 不同角色具有不同操作權限
* 僅 admin 可進行刪除等敏感操作
* 前端與後端皆進行權限檢查

### 產品管理（CRUD）

* 新增（Create）
* 檢視（Read）
* 編輯（Update）
* 刪除（Delete）

---

## 技術架構

* ASP.NET MVC
* Entity Framework Core
* SQLite
* C#
* Razor View

---

## 系統設計說明

### 登入驗證流程

1. 使用者輸入帳號密碼
2. 後端驗證資料庫
3. 成功後將使用者資訊存入 Session
4. 透過 Session 判斷登入狀態與權限

---

### 權限控制設計

系統依據使用者角色（Role）進行授權控制：

* admin：可進行所有操作
* user：僅可查看與部分操作

---

### 安全性說明

* 系統不信任前端傳入資料（避免被竄改）
* 權限控制皆由後端進行驗證
* 使用 Session 控制登入狀態

---

## 專案結構（簡述）

* Controllers：處理業務邏輯（Account / Product）
* Models：資料模型（User / Product）
* Views：前端頁面（Razor）
* Data：資料庫連線與 DbContext

---

## 學習重點

透過本專案，我學習到：

* MVC 架構分層概念
* 資料庫操作（CRUD）
* 使用 Session 管理登入狀態
* 基本權限控制（Role-Based Access Control）
* 前後端責任分離的概念

---

## 未來改進方向

* 導入 ASP.NET Core 內建驗證機制（Authorize）
* 增強資料驗證與錯誤處理
* 提升系統安全性（如密碼加密）
* UI/UX 優化

---


## 備註

本專案以學習與展示為目的，重點在於理解系統運作與設計思維。
