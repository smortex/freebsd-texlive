# New ports collection makefile for:	texlive-hyphen-hungarian
# Date created:		09/21/2010 11:43:04
# Whom:		romain@FreeBSD.org
#
# $FreeBSD$
#

PORTNAME=	hyphen-hungarian
PORTVERSION=	20101020
CATEGORIES=	print
DISTFILES=	# None

MAINTAINER=	romain@FreeBSD.org
COMMENT=	New Hungarian hyphenation patterns.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
