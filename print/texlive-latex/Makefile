# $FreeBSD$

PORTNAME=	latex
PORTVERSION=	20141114
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	A TeX macro package that defines LaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/config/luatex-unicode-letters.tex:${PORTSDIR}/print/texlive-luatex \
		${LOCALBASE}/share/texmf-dist/fonts/map/dvips/dummy-space/dummy-space.map:${PORTSDIR}/print/texlive-pdftex \
		${LOCALBASE}/share/texmf-dist/tex/latex/latexconfig/color.cfg:${PORTSDIR}/print/texlive-latexconfig \
		${LOCALBASE}/share/texmf-dist/fonts/source/public/latex-fonts/circle.mf:${PORTSDIR}/print/texlive-latex-fonts

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
