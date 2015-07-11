# $FreeBSD$

PORTNAME=	polyglossia
PORTVERSION=	20150709
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	An alternative to babel for XeLaTeX and LuaLaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/etoolbox/etoolbox.sty:${PORTSDIR}/print/texlive-etoolbox \
		${LOCALBASE}/share/texmf-dist/tex/latex/fontspec/fontspec.sty:${PORTSDIR}/print/texlive-fontspec \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/latex/makecmds/makecmds.sty:${PORTSDIR}/print/texlive-makecmds \
		${LOCALBASE}/share/texmf-dist/tex/generic/xkeyval/xkeyval.tex:${PORTSDIR}/print/texlive-xkeyval

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
