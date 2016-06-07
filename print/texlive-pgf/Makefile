# $FreeBSD$

PORTNAME=	pgf
PORTVERSION=	20160509
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Create PostScript and PDF graphics in TeX

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/xkeyval/xkeyval.tex:${PORTSDIR}/print/texlive-xkeyval

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
