# $FreeBSD$

PORTNAME=	hyphen-greek
PORTVERSION=	20140418
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Modern Greek hyphenation patterns.

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
