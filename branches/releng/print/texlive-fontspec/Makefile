# $FreeBSD$

PORTNAME=	fontspec
PORTVERSION=	20140418
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Advanced font selection in XeLaTeX and LuaLaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/iftex/iftex.sty:${PORTSDIR}/print/texlive-iftex \
		${LOCALBASE}/share/texmf-dist/tex/generic/kastrup/binhex.tex:${PORTSDIR}/print/texlive-kastrup \
		${LOCALBASE}/share/texmf-dist/makeindex/l3kernel/l3doc.ist:${PORTSDIR}/print/texlive-l3kernel \
		${LOCALBASE}/share/texmf-dist/tex/latex/l3packages/l3keys2e/l3keys2e.sty:${PORTSDIR}/print/texlive-l3packages \
		${LOCALBASE}/share/texmf-dist/fonts/afm/public/lm/lmb10.afm:${PORTSDIR}/print/texlive-lm


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
