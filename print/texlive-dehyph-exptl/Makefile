# New ports collection makefile for:	texlive-dehyph-exptl
# Date created:		13/03/2010 04:35:31
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	dehyph-exptl
PORTVERSION=	20110806
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Experimental hyphenation patterns for the German language.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/tex/generic/config/language.dat:${PORTSDIR}/print/texlive-hyphen-base \
		${LOCALBASE}/share/texmf-dist/tex/generic/hyph-utf8/conversions/conv-utf8-ec.tex:${PORTSDIR}/print/texlive-hyph-utf8

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
