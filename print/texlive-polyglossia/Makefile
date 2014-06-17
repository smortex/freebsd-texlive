# $FreeBSD$

PORTNAME=	polyglossia
PORTVERSION=	20140522
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Modern multilingual typesetting with XeLaTeX.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/latex/etoolbox/etoolbox.sty:${PORTSDIR}/print/texlive-etoolbox \
		${LOCALBASE}/share/texmf-dist/tex/latex/fontspec/fontspec.sty:${PORTSDIR}/print/texlive-fontspec \
		${LOCALBASE}/share/texmf-dist/tex/generic/oberdiek/ifluatex.sty:${PORTSDIR}/print/texlive-ifluatex \
		${LOCALBASE}/share/texmf-dist/tex/latex/makecmds/makecmds.sty:${PORTSDIR}/print/texlive-makecmds \
		${LOCALBASE}/share/texmf-dist/tex/generic/xkeyval/xkeyval.tex:${PORTSDIR}/print/texlive-xkeyval


.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
